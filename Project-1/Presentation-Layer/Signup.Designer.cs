namespace Project_1.Presentation_Layer
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.txtfname = new ns1.BunifuMaterialTextbox();
            this.txtlname = new ns1.BunifuMaterialTextbox();
            this.txtemail = new ns1.BunifuMaterialTextbox();
            this.txtpassword = new ns1.BunifuMaterialTextbox();
            this.txtrepassord = new ns1.BunifuMaterialTextbox();
            this.bunifuCheckbox1 = new ns1.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblsignup = new System.Windows.Forms.Label();
            this.btnsignup = new ns1.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 34);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(294, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(31, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "_";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(330, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(33, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtfname
            // 
            this.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtfname.ForeColor = System.Drawing.Color.White;
            this.txtfname.HintForeColor = System.Drawing.Color.Empty;
            this.txtfname.HintText = "";
            this.txtfname.isPassword = false;
            this.txtfname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtfname.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtfname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtfname.LineThickness = 3;
            this.txtfname.Location = new System.Drawing.Point(38, 139);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(126, 44);
            this.txtfname.TabIndex = 2;
            this.txtfname.Text = "First Name";
            this.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtfname.OnValueChanged += new System.EventHandler(this.txtfname_OnValueChanged);
            this.txtfname.Enter += new System.EventHandler(this.txtfname_Enter);
            this.txtfname.Leave += new System.EventHandler(this.txtfname_Leave);
            // 
            // txtlname
            // 
            this.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtlname.ForeColor = System.Drawing.Color.White;
            this.txtlname.HintForeColor = System.Drawing.Color.Empty;
            this.txtlname.HintText = "";
            this.txtlname.isPassword = false;
            this.txtlname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtlname.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtlname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtlname.LineThickness = 3;
            this.txtlname.Location = new System.Drawing.Point(209, 139);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(126, 44);
            this.txtlname.TabIndex = 3;
            this.txtlname.Text = "Last Name";
            this.txtlname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtlname.Enter += new System.EventHandler(this.txtlname_Enter);
            this.txtlname.Leave += new System.EventHandler(this.txtlname_Leave);
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtemail.ForeColor = System.Drawing.Color.White;
            this.txtemail.HintForeColor = System.Drawing.Color.Empty;
            this.txtemail.HintText = "";
            this.txtemail.isPassword = false;
            this.txtemail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtemail.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtemail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtemail.LineThickness = 3;
            this.txtemail.Location = new System.Drawing.Point(38, 200);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(297, 44);
            this.txtemail.TabIndex = 4;
            this.txtemail.Text = "Email";
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtpassword
            // 
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpassword.ForeColor = System.Drawing.Color.White;
            this.txtpassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtpassword.HintText = "";
            this.txtpassword.isPassword = false;
            this.txtpassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtpassword.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtpassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtpassword.LineThickness = 3;
            this.txtpassword.Location = new System.Drawing.Point(38, 264);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(297, 44);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.Text = "Password";
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.OnValueChanged += new System.EventHandler(this.txtpassword_OnValueChanged);
            this.txtpassword.Enter += new System.EventHandler(this.txtpassword_Enter);
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // txtrepassord
            // 
            this.txtrepassord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrepassord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrepassord.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtrepassord.ForeColor = System.Drawing.Color.White;
            this.txtrepassord.HintForeColor = System.Drawing.Color.Empty;
            this.txtrepassord.HintText = "";
            this.txtrepassord.isPassword = false;
            this.txtrepassord.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtrepassord.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtrepassord.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtrepassord.LineThickness = 3;
            this.txtrepassord.Location = new System.Drawing.Point(38, 330);
            this.txtrepassord.Margin = new System.Windows.Forms.Padding(4);
            this.txtrepassord.Name = "txtrepassord";
            this.txtrepassord.Size = new System.Drawing.Size(297, 44);
            this.txtrepassord.TabIndex = 6;
            this.txtrepassord.Text = "Re-Enter Password";
            this.txtrepassord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtrepassord.Enter += new System.EventHandler(this.txtrepassord_Enter);
            this.txtrepassord.Leave += new System.EventHandler(this.txtrepassord_Leave);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(38, 393);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 7;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Accept the term and  condition";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblsignup
            // 
            this.lblsignup.AutoSize = true;
            this.lblsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblsignup.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignup.ForeColor = System.Drawing.Color.White;
            this.lblsignup.Location = new System.Drawing.Point(84, 62);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Padding = new System.Windows.Forms.Padding(5);
            this.lblsignup.Size = new System.Drawing.Size(98, 34);
            this.lblsignup.TabIndex = 10;
            this.lblsignup.Text = "Signup";
            // 
            // btnsignup
            // 
            this.btnsignup.ActiveBorderThickness = 1;
            this.btnsignup.ActiveCornerRadius = 20;
            this.btnsignup.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsignup.ActiveForecolor = System.Drawing.Color.White;
            this.btnsignup.ActiveLineColor = System.Drawing.Color.White;
            this.btnsignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btnsignup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsignup.BackgroundImage")));
            this.btnsignup.ButtonText = "SignUp";
            this.btnsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsignup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.Color.White;
            this.btnsignup.IdleBorderThickness = 1;
            this.btnsignup.IdleCornerRadius = 20;
            this.btnsignup.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsignup.IdleForecolor = System.Drawing.Color.White;
            this.btnsignup.IdleLineColor = System.Drawing.Color.White;
            this.btnsignup.Location = new System.Drawing.Point(100, 427);
            this.btnsignup.Margin = new System.Windows.Forms.Padding(5);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(163, 49);
            this.btnsignup.TabIndex = 11;
            this.btnsignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(145, 493);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "LogIn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(372, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.lblsignup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.txtrepassord);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuMaterialTextbox txtfname;
        private ns1.BunifuCheckbox bunifuCheckbox1;
        private ns1.BunifuMaterialTextbox txtrepassord;
        private ns1.BunifuMaterialTextbox txtpassword;
        private ns1.BunifuMaterialTextbox txtemail;
        private ns1.BunifuMaterialTextbox txtlname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuThinButton2 btnsignup;
        private System.Windows.Forms.Label lblsignup;
        private System.Windows.Forms.Label label2;
    }
}