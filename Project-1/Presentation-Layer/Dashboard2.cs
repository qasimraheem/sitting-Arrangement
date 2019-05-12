using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1.Data_Layer;
using Project_1.Common_Layer;
using System.Data.OleDb;


namespace Project_1.Presentation_Layer
{
    public partial class Dashboard2 : Form
    {
        public Dashboard2()
        {
            InitializeComponent();
        }
        DataSet result;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            /* string constr = "Provider =Microsoft.jet.OLEDB.4.0;Data Source=" + textBox1.Text + "; Extended Properties =\"Excel 8.0;HDR=Yes;\";";
             OleDbConnection con = new OleDbConnection(constr);
             OleDbDataAdapter sda = new OleDbDataAdapter("Select  * From [" + textBox2.Text + "$]", con);
             DataTable dt = new DataTable();
             sda.Fill(dt);*/
            Arrangment_data arrangment_Data = new Arrangment_data();
            DataTable dt=arrangment_Data.readfromexcel(textBox1.Text, textBox2.Text);
            grideviewsheet.DataSource = dt;
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
