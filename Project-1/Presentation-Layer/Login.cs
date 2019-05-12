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


namespace Project_1.Presentation_Layer
{
    public partial class Login : Form
    {
        string password;
        public Login()
        {
            InitializeComponent();
            string password="";
        }
        

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.password = txtpassword.Text;
            admin.email = txtid.Text;

            Admin_Data admin_Data = new Admin_Data();
            Admin currentAdmin = new Admin();

            currentAdmin = admin_Data.adminLogin(admin);
            if (currentAdmin != null)
            {
                //MessageBox.Show(currentAdmin.email + currentAdmin.first_name);
                Dashboard dashboard = new Dashboard(currentAdmin);
                this.Hide();
                dashboard.Show();
                
            }
            else {
                MessageBox.Show("User Not Found");
            }
        }

        private void txtid_OnTextChange(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            if (txtid.Text=="Email ID") {
                txtid.Text = "";
            }
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                txtid.Text = "Email ID";
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Text = "";
                txtpassword.isPassword = true;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Password";
                txtpassword.isPassword = false;
            }
        }


        private void txtpassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
