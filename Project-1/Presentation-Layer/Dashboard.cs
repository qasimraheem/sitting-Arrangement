﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1.Common_Layer;
using Project_1.Data_Layer;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace Project_1.Presentation_Layer
{
    public partial class Dashboard : Form
    {
        Admin admin = new Admin();
        public Dashboard(Admin currentAdmin)
        {
            this.admin = currentAdmin;
            InitializeComponent();
            panelsetting.Dock = DockStyle.Fill;
            panelsetting.TabIndex = 0;
            panelsetting.Visible = true;
            panelstudent.Visible = false;
            panalroom.Visible = false;
            panelarrangement.Visible = false;
            txtfname.Text = admin.first_name;
            txtlname.Text = admin.last_name;
            txtemail.Text = admin.email;
        }
        //public void setAdmin(Admin admin) {

        //}

   

        private void btnadmin_Click(object sender, EventArgs e)
        {
            panelsetting.Dock = DockStyle.Fill;
            panelsetting.TabIndex = 0;
            panelsetting.Visible = true;
            panelstudent.Visible = false;
            panalroom.Visible = false;
            panelarrangement.Visible = false;
        }

        private void btnarrangement_Click(object sender, EventArgs e)
        {
            panelarrangement.Dock = DockStyle.Fill;
            panelsetting.Visible = false;
            panelstudent.Visible = false;
            panalroom.Visible = false;
            panelarrangement.Visible = true;
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            panalroom.Dock = DockStyle.Fill;
            panelsetting.Visible = false;
            panelstudent.Visible = false;
            panalroom.Visible = true;
            panelarrangement.Visible = false;
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            panelstudent.Dock = DockStyle.Fill;
            panelsetting.Visible = false;
            panelstudent.Visible = true;
            panalroom.Visible = false;
            panelarrangement.Visible = false;
        }

        private void btnsaveadmin_Click(object sender, EventArgs e)
        {
            
           
                Admin tempadmin = new Admin();
                tempadmin.email = txtemail.Text;
                tempadmin.first_name = txtfname.Text;
                tempadmin.last_name = txtlname.Text;
                tempadmin.password = txtpassword.Text;
                if (tempadmin.validateConfPassword(tempadmin.password, txtconfpassword.Text))
                {
                    if (tempadmin.validateAll())
                    {
                        Admin_Data data = new Admin_Data();
                        data.editadmin(tempadmin);
                      
                    }
                    else
                    {
                        //MessageBox.Show("email is not valid!");
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match!");
                }

           

        }

        private void txtfname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtlname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtfname_OnValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtlname_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtemail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtconfpassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnsavearrangement_Click(object sender, EventArgs e)
        {
            Arrangement arrangement = new Arrangement();
            arrangement.arrangementName = txtarrangement.Text;
            arrangement.adminID = admin.id;
            string[] clist = listroom.Items.OfType<string>().ToArray();
            int index = 0;
            foreach (string items in clist)
            {
                DBConnection dbcon = new DBConnection();
                dbcon.SqlQuery("SELECT * FROM RoomsTable WHERE  AdminID=@adminID AND RoomNumber=@roomNumber");
                dbcon.cmd.Parameters.AddWithValue("@adminID", admin.id);
                dbcon.cmd.Parameters.AddWithValue("@roomNumber", clist[index]);
                int val = dbcon.ExNonQuery();
                if (dbcon.cmd.ExecuteScalar() == null)
                {

                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = dbcon.ExQuery();
                    DataRow dr = dbcon.dt.Rows[0];
                    Room room = new Room();
                    room.roomID = (int)dr["RoomID"];
                    room.roomNumber = dr["RoomNumber"].ToString();
                    room.adminID = (int)dr["AdminID"];
                    room.rows = (int)dr["Rows"];
                    room.cols = (int)dr["Cols"];
                    room.totalSeats = (int)dr["TotalSeats"];


                    DBConnection dbcon2 = new DBConnection();
                    dbcon2.SqlQuery("INSERT INTO ArrangementDetails (ArrangementName,AdminID,RoomID) VALUES ( @arrangementName, @adminID, @roomID)");
                    dbcon2.cmd.Parameters.AddWithValue("@arrangementName", arrangement.arrangementName);
                    dbcon2.cmd.Parameters.AddWithValue("@adminID", admin.id);
                    dbcon2.cmd.Parameters.AddWithValue("@roomID", room.roomID);
                    int val2 = dbcon2.ExNonQuery();
                   // MessageBox.Show("Saved");

                }
                index++;
            }
           


        }

        private void droproom_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void droproom_Enter(object sender, EventArgs e)
        {
            droproom.Items.Clear();
           DBConnection dbcon = new DBConnection();
            dbcon.SqlQuery("SELECT * FROM RoomsTable");
            if (dbcon.cmd.ExecuteScalar() == null)
            {

            }
            else
            {
                DataTable dt = new DataTable();
                dt = dbcon.ExQuery();
               // MessageBox.Show(dt.Rows.Count.ToString());
                foreach (DataRow dr in dt.Rows)
                {
                    droproom.Items.Add(dr["RoomNumber"].ToString());
                }
                
            }
            

        }

        private void btnselectroom_Click(object sender, EventArgs e)
        {
            var item = this.droproom.selectedValue;
            listroom.Items.Add(item);

        }

        private void btnsaverooms_Click(object sender, EventArgs e)
        {
            if (txtroomnumber.Enabled)
            {

                Room room = new Room();
                room.rows = Int32.Parse(txtrow.Text);
                room.cols = Int32.Parse(txtcol.Text);
                room.totalSeats = Int32.Parse(txttotal.Text);
                room.adminID = admin.id;
                room.roomNumber = txtroomnumber.Text;

                DBConnection dbcon2 = new DBConnection();
                dbcon2.SqlQuery("INSERT INTO RoomsTable (Rows,Cols,TotalSeats,AdminID,RoomNumber) VALUES ( @rows, @cols, @totalSeats, @adminID, @roomNumber)");
                dbcon2.cmd.Parameters.AddWithValue("@rows", room.rows);
                dbcon2.cmd.Parameters.AddWithValue("@cols", room.cols);
                dbcon2.cmd.Parameters.AddWithValue("@totalSeats", room.totalSeats);
                dbcon2.cmd.Parameters.AddWithValue("@adminID", room.adminID);
                dbcon2.cmd.Parameters.AddWithValue("@roomNumber", room.roomNumber);
                int val = dbcon2.ExNonQuery();

                txtroomnumber.Text = "Room Number";
                txtrow.Text = "Rows";
                txtcol.Text = "Cols";
                txttotal.Text = "Total Seats";
            }
            else if ((!txtroomnumber.Enabled) && (datagridroom.Rows.Count > 0))
            {
                foreach (DataGridViewRow row in datagridroom.Rows)
                {
                    DBConnection dbcon2 = new DBConnection();
                    dbcon2.SqlQuery("INSERT INTO RoomsTable (Rows,Cols,TotalSeats,AdminID,RoomNumber) VALUES ( @rows, @cols, @totalSeats, @adminID, @roomNumber)");
                    dbcon2.cmd.Parameters.AddWithValue("@rows", row.Cells["TotalRows"].Value);
                    dbcon2.cmd.Parameters.AddWithValue("@cols", row.Cells["TotalCols"].Value);
                    dbcon2.cmd.Parameters.AddWithValue("@totalSeats", row.Cells["TotalSeats"].Value);
                    dbcon2.cmd.Parameters.AddWithValue("@adminID", admin.id);
                    dbcon2.cmd.Parameters.AddWithValue("@roomNumber", row.Cells["RoomNumber"].Value);
                    int val = dbcon2.ExNonQuery();
                }

                datagridroom.DataSource = null;
                comboroomdrop.DataSource = null;
                txtroompath.Text = "";
                comboroomdrop.Items.Clear();
                datagridroom.Rows.Clear();
                datagridroom.Refresh();
            }
            else
            {
                MessageBox.Show("Data not set");
            }
            
        }

        private void droparrangement_Enter(object sender, EventArgs e)
        {
            droparrangement.Items.Clear();
            DBConnection dbcon = new DBConnection();
            dbcon.SqlQuery("SELECT DISTINCT ArrangementName FROM ArrangementDetails where AdminID=@adminID");
            dbcon.cmd.Parameters.AddWithValue("@adminID",admin.id);
            if (dbcon.cmd.ExecuteScalar() == null)
            {
                MessageBox.Show("not found");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = dbcon.ExQuery();
                foreach (DataRow dr in dt.Rows)
                {
                    droparrangement.Items.Add(dr["ArrangementName"].ToString());
                   // MessageBox.Show(dr["ID"].ToString());
                }
 
            }
        }

        private void btnloadfile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel File | *.xlsx; *.xls; *.xlsm";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtfilepath.Text = openFileDialog.FileName;
                }
                string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtfilepath.Text + ";Extended Properties = \"Excel 12.0; HDR=Yes;\" ; ";
                OleDbConnection con = new OleDbConnection(constr);
                con.Open();
                dropsheet.DataSource = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                dropsheet.DisplayMember = "TABLE_NAME";
                dropsheet.ValueMember = "TABLE_NAME";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dropsheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtfilepath.Text + ";Extended Properties = \"Excel 12.0; HDR=Yes;\" ; ";
                OleDbConnection con = new OleDbConnection(constr);
                OleDbDataAdapter sda = new OleDbDataAdapter("Select CMS from [" + dropsheet.SelectedValue + "]", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    grideviewsheet.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsavestudents_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.adminID = admin.id;
            student.subject = txtsubject.Text;
            student.subjectCode = txtsubjectcode.Text;
            student.classs = txtclasss.Text;
            student.arrangementName = droparrangement.selectedValue;
           // string[] clist = listroom.Items.OfType<string>().ToArray();
            if((grideviewsheet.Rows.Count > 0))
            {
                foreach (DataGridViewRow row in grideviewsheet.Rows)
                {
                    DBConnection dbcon = new DBConnection();
                    dbcon.SqlQuery("INSERT INTO RawStudentsTable (Subject,SubjectCode,Classs,ArrangementName,AdminID,Cms) VALUES ( @subject, @subjectCode, @classs, @arrangementName, @adminID, @cms)");
                    dbcon.cmd.Parameters.AddWithValue("@subject",student.subject);
                    dbcon.cmd.Parameters.AddWithValue("@subjectCode", student.subjectCode);
                    dbcon.cmd.Parameters.AddWithValue("@classs", student.classs);
                    dbcon.cmd.Parameters.AddWithValue("@arrangementName", student.arrangementName);
                    dbcon.cmd.Parameters.AddWithValue("@adminID", student.adminID);
                    dbcon.cmd.Parameters.AddWithValue("@cms", row.Cells["Cms"].Value);
                    int val = dbcon.ExNonQuery();
                }

                grideviewsheet.DataSource = null;
                
                txtfilepath.Text = "";
                droparrangement.Items.Clear();
                grideviewsheet.Rows.Clear();
                grideviewsheet.Refresh();
            }
        }
        private void btnArrange_Click(object sender, EventArgs e)
        {

        }

        private void txtroomnumber_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtroomnumber_Enter(object sender, EventArgs e)
        {
            if (txtroomnumber.Text == "Room Number")
            {
                txtroomnumber.Text = "";
            }
        }

        private void txtroomnumber_Leave(object sender, EventArgs e)
        {
            if (txtroomnumber.Text == "")
            {
                txtroomnumber.Text = "Room Number";
            }
        }

        private void txtrow_Enter(object sender, EventArgs e)
        {
            if (txtrow.Text == "Rows")
            {
                txtrow.Text = "";
            }
        }

        private void txtrow_Leave(object sender, EventArgs e)
        {
            if (txtrow.Text == "")
            {
                txtrow.Text = "Rows";
            }

            int x = 0;
            int y = 0;

            if (Int32.TryParse(txtrow.Text, out x))
            {
                if (Int32.TryParse(txtcol.Text, out y))
                {
                    txttotal.Text = (x * y).ToString();
                    // you know that the parsing attempt
                    // was successful
                }
                else
                {
                    txttotal.Text = "";

                }
                // you know that the parsing attempt
                // was successful
            }
            else
            {
                txttotal.Text = "";

            }

        }

        private void txtcol_Enter(object sender, EventArgs e)
        {
            if (txtcol.Text == "Cols")
            {
                txtcol.Text = "";
            }
        }

        private void txtcol_Leave(object sender, EventArgs e)
        {
            if (txtcol.Text == "")
            {
                txtcol.Text = "Cols";
            }


            int x = 0;
            int y = 0;

            if (Int32.TryParse(txtrow.Text, out x))
            {
                if (Int32.TryParse(txtcol.Text, out y))
                {
                    txttotal.Text = (x * y).ToString();
                    // you know that the parsing attempt
                    // was successful
                }
                else
                {
                    txttotal.Text = "";

                }
                // you know that the parsing attempt
                // was successful
            }
            else
            {
                txttotal.Text = "";

            }
        }

     

        private void txttotal_Leave(object sender, EventArgs e)
        {
            if (txttotal.Text == "")
            {
                txttotal.Text = "Total Seats";
            }
        }

        private void txttotal_Enter(object sender, EventArgs e)
        {
            if (txttotal.Text == "Total Seats")
            {
                txttotal.Text = "";
            }
        }

        private void btnroomload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel File | *.xlsx; *.xls; *.xlsm";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtroompath.Text = openFileDialog.FileName;
                }
                string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtroompath.Text + ";Extended Properties = \"Excel 12.0; HDR=Yes;\" ; ";
                OleDbConnection con = new OleDbConnection(constr);
                con.Open();
                comboroomdrop.DataSource = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                comboroomdrop.DisplayMember = "TABLE_NAME";
                comboroomdrop.ValueMember = "TABLE_NAME";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboroomdrop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboroomdrop_Leave(object sender, EventArgs e)
        {
           
        }

        private void comboroomdrop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtroompath.Text + ";Extended Properties = \"Excel 12.0; HDR=Yes;\" ; ";
                OleDbConnection con = new OleDbConnection(constr);
                OleDbDataAdapter sda = new OleDbDataAdapter("Select RoomNumber,TotalRows,TotalCols,TotalSeats from [" + comboroomdrop.SelectedValue + "]", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    datagridroom.DataSource = dt;
                }
                txtroomnumber.Enabled = false;
                txtrow.Enabled = false;
                txtcol.Enabled = false;
                txttotal.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnroomclear_Click(object sender, EventArgs e)
        {
            txtroomnumber.Enabled = true;
            txtrow.Enabled = true;
            txtcol.Enabled = true;
            txttotal.Enabled = true;
            txtroomnumber.Text="Room Number";
            txtrow.Text="Rows";
            txtcol.Text="Cols";
            txttotal.Text="Total Seats";
            datagridroom.DataSource = null;
            comboroomdrop.DataSource = null;
            txtroompath.Text = "";
            comboroomdrop.Items.Clear();
            datagridroom.Rows.Clear();
            datagridroom.Refresh();
        }

        private void droparrangement_onItemSelected(object sender, EventArgs e)
        {

        }

        private void txtarrangement_Enter(object sender, EventArgs e)
        {
            if (txtarrangement.Text == "Arrangement / Event Name")
            {
                txtarrangement.Text = "";
            }
        }

        private void txtarrangement_Leave(object sender, EventArgs e)
        {
            if (txtarrangement.Text == "")
            {
                txtarrangement.Text = "Arrangement / Event Name";
            }
        }

        private void txtsubject_Enter(object sender, EventArgs e)
        {
            if (txtsubject.Text == "Subject")
            {
                txtsubject.Text = "";
            }
        }

        private void txtsubject_Leave(object sender, EventArgs e)
        {
            if (txtsubject.Text == "")
            {
                txtsubject.Text = "Subject";
            }
        }

        private void txtsubjectcode_Enter(object sender, EventArgs e)
        {
            if (txtsubjectcode.Text == "Subject Code")
            {
                txtsubjectcode.Text = "";
            }
        }

        private void txtsubjectcode_Leave(object sender, EventArgs e)
        {
            if (txtsubjectcode.Text == "")
            {
                txtsubjectcode.Text = "Subject Code";
            }
        }

        private void txtclasss_Enter(object sender, EventArgs e)
        {
            if (txtclasss.Text == "Class")
            {
                txtclasss.Text = "";
            }
        }

        private void txtclasss_Leave(object sender, EventArgs e)
        {
            if (txtclasss.Text == "")
            {
                txtclasss.Text = "Class";
            }
        }

        private void datagridroom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
