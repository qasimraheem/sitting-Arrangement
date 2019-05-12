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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                Admin admin = new Admin();
                admin.first_name = txtfname.Text;
                admin.last_name = txtlname.Text;
                admin.password = txtpassword.Text;
                admin.email = txtemail.Text;
                if (admin.validateConfPassword(admin.password, txtrepassord.Text)) {
                    if (admin.validateAll())
                    {
                        Admin_Data data = new Admin_Data();
                        data.addadmin(admin);
                        Login login = new Login();
                        this.Hide();
                        login.Show();
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
            else {
                MessageBox.Show("ACCEPT THE TERM AND CONDITION");
            }

        }

        private void txtfname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void txtfname_Enter(object sender, EventArgs e)
        {
            if(txtfname.Text=="First Name")
            {
                txtfname.Text = "";
            }
        }

        private void txtfname_Leave(object sender, EventArgs e)
        {
            if (txtfname.Text == "")
            {
                txtfname.Text = "First Name";
            }
        }
    }
}
