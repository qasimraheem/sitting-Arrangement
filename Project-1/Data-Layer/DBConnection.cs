using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Project_1.Data_Layer
{
    public class DBConnection {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        public DBConnection()
    {
        

    // con = new SqlConnection(conStr);
    con = new SqlConnection("Data Source=DESKTOP-2PU6R1E\\QASIM;Initial Catalog=Seating_Arrangement;Integrated Security=True");

        con.Open();
    }

    public void SqlQuery(string query)
    {
        cmd = new SqlCommand(query, con);

    }

    public DataTable ExQuery()
    {
        da = new SqlDataAdapter(cmd);
        dt = new DataTable();
        da.Fill(dt);
        return dt;
    }

    public int ExNonQuery()
    {
        int value = cmd.ExecuteNonQuery();
        return value;
    }

}
}

