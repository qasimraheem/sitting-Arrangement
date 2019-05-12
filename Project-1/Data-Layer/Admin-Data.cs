using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
 using System.Windows.Forms;
using Project_1.Common_Layer;
using System.Security.Cryptography;

namespace Project_1.Data_Layer
{
    class Admin_Data
    {
        DBConnection dbcon;
        public Admin_Data()
        {
            dbcon = new DBConnection();
        }
        public int  addadmin(Admin admin)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(admin.password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            


            dbcon.SqlQuery("INSERT INTO AdminDetails (First_Name, Last_Name, Password,Email) VALUES (@fname, @lname, @password,@email)");
            dbcon.cmd.Parameters.AddWithValue("@fname", admin.first_name);
            dbcon.cmd.Parameters.AddWithValue("@lname", admin.last_name);
            dbcon.cmd.Parameters.AddWithValue("@password", savedPasswordHash);
            dbcon.cmd.Parameters.AddWithValue("@email", admin.email);
            int val = dbcon.ExNonQuery();
            return val;
        }
        public int editadmin(Admin admin)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(admin.password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);



            dbcon.SqlQuery("UPDATE AdminDetails SET (First_Name, Last_Name, Password,Email) VALUES (@fname, @lname, @password, @email) WHERE Email = @email");
            dbcon.cmd.Parameters.AddWithValue("@fname", admin.first_name);
            dbcon.cmd.Parameters.AddWithValue("@lname", admin.last_name);
            dbcon.cmd.Parameters.AddWithValue("@password", savedPasswordHash);
            dbcon.cmd.Parameters.AddWithValue("@email", admin.email);
            int val = dbcon.ExNonQuery();
            return val;
        }
        public DataTable getAlladmin()
        {
            dbcon.SqlQuery("alladmin");
            dbcon.cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt = dbcon.ExQuery();
            return dt;
        }
        public Admin adminLogin(Admin admin) {
            dbcon.SqlQuery("select * from AdminDetails where Email=@email");
            dbcon.cmd.Parameters.AddWithValue("@email", admin.email);
            if (dbcon.cmd.ExecuteScalar() == null)
            {
                return null;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = dbcon.ExQuery();
                DataRow dr = dbcon.dt.Rows[0];
                Admin temp = new Admin();
                temp.id = (int)dr["ID"];
                temp.email = dr["Email"].ToString();
                temp.first_name = dr["First_Name"].ToString();
                temp.last_name = dr["Last_Name"].ToString();
                temp.password = dr["Password"].ToString();

                string savedPasswordHash = temp.password;
                /* Extract the bytes */
                byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                /* Get the salt */
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                /* Compute the hash on the password the user entered */
                var pbkdf2 = new Rfc2898DeriveBytes(admin.password, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);
                /* Compare the results */
                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] != hash[i]) {
                        MessageBox.Show("Invalid Password");
                      
                        return null;
                    }

                return temp;
            }
        }

    }
}
