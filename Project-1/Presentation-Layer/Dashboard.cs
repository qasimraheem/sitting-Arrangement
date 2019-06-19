using System;
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
        Arrangement[] currentarrangement;
        int currentarrangementcount;
        Room[] selectedRooms;
        Student[] selectedStudents;
        int[,] remaininglists;
        

        public Dashboard(Admin currentAdmin)
        {
            this.admin = currentAdmin;
            InitializeComponent();
            panelstudent.Dock = DockStyle.Fill;
            panelstudent.TabIndex = 0;
            panelsetting.Visible = false;
            panelstudent.Visible = true;
            panalroom.Visible = false;
            panelarrangement.Visible = false;
            panel3.Visible = false;
            txtfname.Text = admin.first_name;
            txtlname.Text = admin.last_name;
            txtemail.Text = admin.email;

            

            starttime.Format = DateTimePickerFormat.Custom;
            starttime.CustomFormat = "dd-MM-yy hh:mm tt";
            endtime.Format = DateTimePickerFormat.Custom;
            endtime.CustomFormat = "dd-MM-yy hh:mm tt";
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
            //hello

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

        //private void droparrangement_Enter(object sender, EventArgs e)
        //{
        //    droparrangement.Items.Clear();
        //    DBConnection dbcon = new DBConnection();
        //    dbcon.SqlQuery("SELECT DISTINCT ArrangementName FROM ArrangementDetails where AdminID=@adminID");
        //    dbcon.cmd.Parameters.AddWithValue("@adminID",admin.id);
        //    if (dbcon.cmd.ExecuteScalar() == null)
        //    {
        //        MessageBox.Show("not found");
        //    }
        //    else
        //    {
        //        DataTable dt = new DataTable();
        //        dt = dbcon.ExQuery();
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            droparrangement.Items.Add(dr["ArrangementName"].ToString());
        //           // MessageBox.Show(dr["ID"].ToString());
        //        }

        //    }
        //}

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

            // string[] clist = listroom.Items.OfType<string>().ToArray();
            if ((grideviewsheet.Rows.Count > 0))
            {
                foreach (DataGridViewRow row in grideviewsheet.Rows)
                {
                    DBConnection dbcon = new DBConnection();
                    dbcon.SqlQuery("INSERT INTO RawStudentsTable (Subject,SubjectCode,Classs,AdminID,Cms) VALUES ( @subject, @subjectCode, @classs,  @adminID, @cms)");
                    dbcon.cmd.Parameters.AddWithValue("@subject", student.subject);
                    dbcon.cmd.Parameters.AddWithValue("@subjectCode", student.subjectCode);
                    dbcon.cmd.Parameters.AddWithValue("@classs", student.classs);
                    dbcon.cmd.Parameters.AddWithValue("@adminID", student.adminID);
                    dbcon.cmd.Parameters.AddWithValue("@cms", row.Cells["Cms"].Value);
                    int val = dbcon.ExNonQuery();
                }

                grideviewsheet.DataSource = null;

                txtfilepath.Text = "";
                // droparrangement.Items.Clear();
                grideviewsheet.Rows.Clear();
                grideviewsheet.Refresh();
            }
        }
        private void btnArrange_Click(object sender, EventArgs e)
        {


            

            int studentsCount = 0;

            string[] clist = listroom.Items.OfType<string>().ToArray();
            int index = 0;
            selectedRooms = new Room[clist.Length];
            DBConnection dbcon = new DBConnection();
            DataTable dt = new DataTable();

            foreach (string items in clist)
            {

                dbcon.SqlQuery("SELECT * FROM RoomsTable WHERE  AdminID=@adminID AND RoomNumber=@roomNumber");
                dbcon.cmd.Parameters.AddWithValue("@adminID", admin.id);
                dbcon.cmd.Parameters.AddWithValue("@roomNumber", clist[index]);
                int val = dbcon.ExNonQuery();
                if (dbcon.cmd.ExecuteScalar() == null)
                {

                }
                else
                {
                    // DataTable dt = new DataTable();
                    dt = dbcon.ExQuery();
                    DataRow dr = dbcon.dt.Rows[0];
                    Room room = new Room();
                    room.roomID = (int)dr["RoomID"];
                    room.roomNumber = dr["RoomNumber"].ToString();
                    room.adminID = (int)dr["AdminID"];
                    room.rows = (int)dr["Rows"];
                    room.cols = (int)dr["Cols"];
                    room.totalSeats = (int)dr["TotalSeats"];

                    selectedRooms[index] = room;
                }
                index++;
            }



            foreach (Room room in selectedRooms)
            {
                // MessageBox.Show(room.totalSeats.ToString());
            }

            dbcon.SqlQuery("SELECT * FROM RawStudentsTable WHERE  AdminID=@adminID");
            dbcon.cmd.Parameters.AddWithValue("@adminID", admin.id);
            // dbcon.cmd.Parameters.AddWithValue("@arrangementName", arrangement.arrangementName);
            int val2 = dbcon.ExNonQuery();

            if (dbcon.cmd.ExecuteScalar() == null)
            {

            }
            else
            {


                // 
                dt = dbcon.ExQuery();
                selectedStudents = new Student[dbcon.dt.Rows.Count];


                int index3 = 0;
                foreach (DataRow dr in dbcon.dt.Rows)
                {
                    Student student = new Student();
                    student.id = (int)dr["ID"];
                    //        student.arrangementName = dr["ArrangementName"].ToString();
                    student.adminID = (int)dr["AdminID"];
                    student.subject = dr["Subject"].ToString();
                    student.subjectCode = dr["SubjectCode"].ToString();
                    student.classs = dr["Classs"].ToString();
                    student.cms = (int)dr["Cms"];

                    selectedStudents[index3] = student;
                    index3++;
                }
                foreach (Student student in selectedStudents)
                {
                    studentsCount++;
                    //MessageBox.Show(student.subjectCode.ToString()+" "+student.cms.ToString());
                }



                if (studentsCount > 0)
                {

                    List<string> subjectCodeList = new List<string>();


                    foreach (Student student in selectedStudents)
                    {
                        bool found = false;
                        int index4 = 0;

                        foreach (string subjectCode in subjectCodeList)
                        {
                            if (student.subjectCode == subjectCode)
                            {
                                found = true;
                                break;
                            }
                            index4++;
                        }
                        if (found == false)
                        {
                            subjectCodeList.Add(student.subjectCode);
                        }


                    }
                    int[] highestSubjectStudents = new int[subjectCodeList.Count];
                    foreach (Student student in selectedStudents)
                    {
                        bool found = false;
                        int index4 = 0;

                        foreach (string subjectCode in subjectCodeList)
                        {
                            if (student.subjectCode == subjectCode)
                            {
                                highestSubjectStudents[index4] += 1;
                            }
                            index4++;
                        }
                    }

                    int highestCount = 0;
                    foreach (int count in highestSubjectStudents)
                    {
                        if (highestCount < count)
                        {
                            highestCount = count;
                        }
                    }


                    int[,] studentsCms = new int[highestSubjectStudents.Length, highestCount];

                    int rawrow = studentsCms.GetUpperBound(0) - studentsCms.GetLowerBound(0) + 1;
                    int rawcol = studentsCms.GetUpperBound(1) - studentsCms.GetLowerBound(1) + 1;
                    //MessageBox.Show(rawrow.ToString() + " and " + rawcol);
                    foreach (Student student in selectedStudents)
                    {

                        int index4 = 0;
                        foreach (string subject in subjectCodeList)
                        {

                            if (student.subjectCode == subject)
                            {
                                //MessageBox.Show(rawrow.ToString() + " and " + rawcol);

                                for (int i = 0; i < highestCount; i++)
                                {
                                    if (studentsCms[index4, i] == 0)
                                    {
                                        studentsCms[index4, i] = student.cms;
                                        // MessageBox.Show(student.subjectCode.ToString() + " " + student.cms.ToString());
                                        break;
                                    }

                                }

                            }
                            index4++;
                        }
                    }

                    string output = "";
                    for (int i = 0; i < rawrow; i++)
                    {
                        for (int j = 0; j < rawcol; j++)
                        {
                            output += (studentsCms[i, j]).ToString();
                        }
                        output += "\r\n";
                    }
                    MessageBox.Show(output);


                    remaininglists = studentsCms;

                    Matrix[] matrixarray = new Matrix[selectedRooms.Length];
                    for (int i = 0; i < selectedRooms.Length; i++) {
                        Matrix matrix = new Matrix(selectedRooms[i].rows, selectedRooms[i].cols,selectedRooms[i]);
                        MessageBox.Show("length"+studentsCms.Length);
                        if (i == 0)
                        {
                            matrix.arrange(studentsCms, rawrow);
                        }
                        else {
                            matrix.arrange(remaininglists, rawrow);
                        }
                        matrix.print();
                        matrix.store();
                        matrixarray[i] = matrix;
                        remaininglists = matrix.lists;
                    }
                    {
                        Microsoft.Office.Interop.Excel.Application oXL;
                        Microsoft.Office.Interop.Excel._Workbook oWB;
                        Microsoft.Office.Interop.Excel._Worksheet  oSheet;
                        try
                        {
                            //Start Excel and get Application object.
                            oXL = new Microsoft.Office.Interop.Excel.Application();
                            oXL.Visible = true;

                            oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;
                            oSheet.Name = "Sheet0";
                            Microsoft.Office.Interop.Excel.Range chartRange;

                            int rowCount = remaininglists.GetLength(0);
                            int columnCount = remaininglists.GetLength(1);
                            chartRange = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[1, 1]; //I have header info on row 1, so start row 2
                            chartRange = chartRange.get_Resize(rowCount, columnCount);
                            chartRange.set_Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault, remaininglists);

                            for(int i=0;i<remaininglists.GetLength(0);i++) {

                                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets.Add(oSheet) ;
                                oSheet.Name = "Sheet" + (i+1);
                                int[,] list= new int[remaininglists.GetLength(1), remaininglists.GetLength(0)];

                                for (int j = 0; j < remaininglists.GetLength(1); j++) {
                                    if (remaininglists[i, j] != 0) {
                                        list[j, 0] = remaininglists[i, j];
                                    }
                                }

                                rowCount = remaininglists.GetLength(1);
                                columnCount = remaininglists.GetLength(0);
                                chartRange = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[1, 1];
                                chartRange.Cells.Value2 = "cms";
                                chartRange = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[2, 1]; //I have header info on row 1, so start row 2
                                chartRange = chartRange.get_Resize(rowCount, 1);
                                chartRange.set_Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault, list);


                            }


                            oXL.Visible = false;
                            oXL.UserControl = false;
                            string outputFile = "Remaining_Students" + index + ".xlsx";
                            string savingPath = "C:\\Users\\qasim\\Desktop\\sitting-Arrangement\\" + outputFile;
                        
                            //+ DateTime.Now.ToString("yyyyMMddHHmmss")
                            oWB.SaveAs(savingPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                                false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                            oWB.Close();
                        }
                        catch (Exception ex)
                        {
                            //...
                        }
                    }
                    index = 0;
                    
                    currentarrangement = new Arrangement[matrixarray.Length];
                  
                    foreach (Matrix matrix in matrixarray) {

                        Microsoft.Office.Interop.Excel.Application oXL;
                        Microsoft.Office.Interop.Excel._Workbook oWB;
                        Microsoft.Office.Interop.Excel._Worksheet oSheet;
                        try
                        {
                            //Start Excel and get Application object.
                            oXL = new Microsoft.Office.Interop.Excel.Application();
                            oXL.Visible = true;

                            oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                            Microsoft.Office.Interop.Excel.Range chartRange;

                            int rowCount = matrix.data.GetLength(0);
                            int columnCount = matrix.data.GetLength(1);
                            chartRange = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[1, 1]; //I have header info on row 1, so start row 2
                            chartRange = chartRange.get_Resize(rowCount, columnCount);
                            chartRange.set_Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault, matrix.data);


                            oXL.Visible = false;
                            oXL.UserControl = false;
                            string outputFile = "Room_" + matrix.room.roomNumber + ".xlsx";
                            string savingPath = "C:\\Users\\qasim\\Desktop\\sitting-Arrangement\\" + outputFile;
                            Arrangement arrangement = new Arrangement();
                            arrangement.roomID = matrix.room.roomID;
                            arrangement.roomSaveFile = savingPath;

                            currentarrangement[index] = arrangement;
                            //+ DateTime.Now.ToString("yyyyMMddHHmmss")
                            oWB.SaveAs( savingPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                                false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                            oWB.Close();
                            index++;

                        }
                        catch (Exception ex)
                        {
                            //...
                        }
                    }
  

                }

            }


            panel3.Visible = true;
            panel3.Dock = DockStyle.Fill;
            panelsetting.Visible = false;
            panelstudent.Visible = false;
            panalroom.Visible = false;
            panelarrangement.Visible = false;

            

        }

        //arrangeing code



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

        private void txtarrangement_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            listroom.Items.Remove(listroom.SelectedItem);
        }

        private void txteventname_Enter(object sender, EventArgs e)
        {
            if (txteventname.Text == "Event Name")
            {
                txteventname.Text = "";
            }
        }

        private void txteventname_Leave(object sender, EventArgs e)
        {
            if (txteventname.Text == "")
            {
                txteventname.Text = "Event Name";
            }
        }

        private void droptype_Enter(object sender, EventArgs e)
        {
            droptype.Items.Clear();
            DBConnection dbcon = new DBConnection();
            dbcon.SqlQuery("SELECT * FROM EventType");
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
                    droptype.Items.Add(dr["EventType"].ToString());
                }

            }
        }

        private void starttime_Enter(object sender, EventArgs e)
        {
            starttime.MinDate= DateTime.Now.AddDays(0);
        }

        private void endtime_Enter(object sender, EventArgs e)
        {
            endtime.MinDate = starttime.Value;
        }

        private void starttime_Leave(object sender, EventArgs e)
        {
            endtime.MinDate = starttime.Value;
        }

     

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {


            DBConnection dbcon = new DBConnection();

           
            EventType eventType = new EventType();
            eventType.eventType = droptype.selectedValue;
            dbcon.SqlQuery("SELECT * FROM EventType WHERE EventType=@eventType");
            dbcon.cmd.Parameters.AddWithValue("@eventType", eventType.eventType);
            if (dbcon.cmd.ExecuteScalar() == null)
            {

            }
            else
            {
                DataTable dt = new DataTable();
                dt = dbcon.ExQuery();
                // MessageBox.Show(dt.Rows.Count.ToString());

                DataRow dr = dt.Rows[0];
               eventType.id = (int)dr["ID"];

            }
            int val = dbcon.ExNonQuery();

            Event_Arrange event_Arrange = new Event_Arrange();
            event_Arrange.name = txteventname.Text;
            event_Arrange.typeID = eventType.id;
            event_Arrange.eventStartDateTime = starttime.Value.ToString();
            event_Arrange.eventEndDateTime = endtime.Value.ToString();
           // event_Arrange.print();

            dbcon.SqlQuery("INSERT INTO Event (Name,TypeID,EventStartDateTime,EventEndDateTime) VALUES ( @name, @typeID, @eventStart, @eventEnd)");
            //  dbcon2.cmd.Parameters.AddWithValue("@arrangementName", arrangement.arrangementName);
            dbcon.cmd.Parameters.AddWithValue("@name", event_Arrange.name);
            dbcon.cmd.Parameters.AddWithValue("@typeID", event_Arrange.typeID);
            dbcon.cmd.Parameters.AddWithValue("@eventStart", event_Arrange.eventStartDateTime);
            dbcon.cmd.Parameters.AddWithValue("@eventEnd", event_Arrange.eventEndDateTime);

             val = dbcon.ExNonQuery();

            dbcon.SqlQuery("SELECT * FROM Event WHERE Name=@name AND TypeID=@typeID AND  EventStartDateTime=@eventStart AND EventEndDateTime=@eventEnd");
            dbcon.cmd.Parameters.AddWithValue("@name", event_Arrange.name);
            dbcon.cmd.Parameters.AddWithValue("@typeID", event_Arrange.typeID);
            dbcon.cmd.Parameters.AddWithValue("@eventStart", event_Arrange.eventStartDateTime);
            dbcon.cmd.Parameters.AddWithValue("@eventEnd", event_Arrange.eventEndDateTime);
             val = dbcon.ExNonQuery();

            if (dbcon.cmd.ExecuteScalar() == null)
            {

            }
            else
            {
                DataTable dt = new DataTable();
                dt = dbcon.ExQuery();
                // MessageBox.Show(dt.Rows.Count.ToString());

                DataRow dr = dt.Rows[0];
                event_Arrange.id = (int)dr["ID"];

            }
            

            //[matrixarray.Length];
             int index=0;

            MessageBox.Show(currentarrangement.Length.ToString());
            for (int i = 0; i < currentarrangement.Length; i++)
            {
                MessageBox.Show("index:" + i + " id:" + event_Arrange.id);
                currentarrangement[i].eventID = event_Arrange.id;
                currentarrangement[i].adminID = admin.id;

                dbcon.SqlQuery("INSERT INTO ArrangementDetails (EventID,AdminID,RoomID,RoomSavedFile) VALUES ( @eventID, @adminID, @roomID, @roomSavedFile)");
                //  dbcon2.cmd.Parameters.AddWithValue("@arrangementName", arrangement.arrangementName);
                dbcon.cmd.Parameters.AddWithValue("@eventID", currentarrangement[i].eventID);
                dbcon.cmd.Parameters.AddWithValue("@adminID", currentarrangement[i].adminID);
                dbcon.cmd.Parameters.AddWithValue("@roomID", currentarrangement[i].roomID);
                dbcon.cmd.Parameters.AddWithValue("@roomSavedFile", currentarrangement[i].roomSaveFile);
                val = dbcon.ExNonQuery();
            }



            if (selectedStudents.Length > 0)
            {
                ArrangedStudents[] arrangedStudentsarray = new ArrangedStudents[selectedStudents.Length];
                index = 0;
                foreach (ArrangedStudents arrangedStudents in arrangedStudentsarray)
                {
                    string name=selectedStudents[0].subjectCode;
                    ArrangedStudents temp = new ArrangedStudents();
                    temp.student(selectedStudents[index]);
                    temp.eventID = event_Arrange.id;
                    arrangedStudentsarray[index] = temp;
                    index++;
                }


                int rowCount = remaininglists.GetLength(0);
                int columnCount = remaininglists.GetLength(1);

                foreach (ArrangedStudents arrangedStudents in arrangedStudentsarray)
                {
                    bool found = false;
                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            if (remaininglists[i, j] == arrangedStudents.cms)
                            {
                                found = true;
                                break;
                            }
                        }
                        if (found == true)
                        {
                            break;
                        }
                    }

                    if (found == false)
                    {
                        dbcon.SqlQuery("INSERT INTO ArrangedStudents (Subject,SubjectCode,Classs,AdminID,Cms,EventID) VALUES ( @subject, @subjectCode, @classs,  @adminID, @cms, @eventID)");
                        dbcon.cmd.Parameters.AddWithValue("@subject", arrangedStudents.subject);
                        dbcon.cmd.Parameters.AddWithValue("@subjectCode", arrangedStudents.subjectCode);
                        dbcon.cmd.Parameters.AddWithValue("@classs", arrangedStudents.classs);
                        dbcon.cmd.Parameters.AddWithValue("@adminID", arrangedStudents.adminID);
                        dbcon.cmd.Parameters.AddWithValue("@eventID", arrangedStudents.eventID);
                        dbcon.cmd.Parameters.AddWithValue("@cms", arrangedStudents.cms);
                        val = dbcon.ExNonQuery();
                    }
                }


            }


        }
    }
}
