using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;
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

namespace Project_1.Common_Layer
{
    public class Admin
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public Admin()
        {

        }
        public Admin(string fn,string ls,string em,string p)
        {
            first_name = fn;
            last_name = ls;
            password = p;
            email = em;
        }
        public bool validateAll(){
           if(this.validateEmail(this.email)&&this.validateUsername(this.first_name) && this.validateUsername(this.last_name)&&this.validatePassword(this.password))
            {
                return true;
            }
            return false;
        }
        public bool validatePassword(string password)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$";
            if (Regex.IsMatch(password, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Password is not valid!");
                return false;
            }
        }
        public bool validateEmail(string email)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("email is not valid!");
                return false;
            }
        }
        public bool validateUsername(string username)
        {
            string pattern = "^[\\p{L} \\.'\\-]+$";
            if (Regex.IsMatch(username, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show(username + "is not valid Name!");
                return false;
            }
        }
        public bool validateConfPassword(string password, string confPassword)
        {
            if (password==confPassword)
            {
                return true;
            }
            else
            {
                MessageBox.Show("confirm Password doesnot match!");
                return false;
            }
        }
    }
}
