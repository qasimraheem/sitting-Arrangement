using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Project_1.Data_Layer
{
    class Arrangment_data
    {
        DBConnection dbco;
        public Arrangment_data()
        {
            dbco = new DBConnection();
        }
        public DataTable readfromexcel(string text1,string text2)
        {
            string constr = "Provider =Microsoft.jet.OLEDB.4.0;Data Source=" + text1 + "; Extended Properties =\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection con = new OleDbConnection(constr);
            OleDbDataAdapter sda = new OleDbDataAdapter("Select  * From [" + text2 + "$]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            
            return dt;
        }
    }
}
