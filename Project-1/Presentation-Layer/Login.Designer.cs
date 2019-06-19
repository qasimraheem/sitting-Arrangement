namespace Project_1.Presentation_Layer
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlogin = new ns1.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsignup = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.txtid = new ns1.BunifuMaterialTextbox();
            this.txtpassword = new ns1.BunifuMaterialTextbox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.panel1.Size = new System.Drawing.Size(333, 34);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(260, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(30, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "_";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(296, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.ActiveBorderThickness = 1;
            this.btnlogin.ActiveCornerRadius = 20;
            this.btnlogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.btnlogin.ActiveForecolor = System.Drawing.Color.Black;
            this.btnlogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btnlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogin.BackgroundImage")));
            this.btnlogin.ButtonText = "Login";
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.IdleBorderThickness = 1;
            this.btnlogin.IdleCornerRadius = 20;
            this.btnlogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.btnlogin.IdleForecolor = System.Drawing.Color.White;
            this.btnlogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.btnlogin.Location = new System.Drawing.Point(78, 402);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(182, 49);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Forget Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsignup
            // 
            this.lblsignup.AutoSize = true;
            this.lblsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblsignup.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignup.ForeColor = System.Drawing.Color.White;
            this.lblsignup.Location = new System.Drawing.Point(118, 457);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Padding = new System.Windows.Forms.Padding(5);
            this.lblsignup.Size = new System.Drawing.Size(92, 32);
            this.lblsignup.TabIndex = 5;
            this.lblsignup.Text = "Signup";
            this.lblsignup.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtid.ForeColor = System.Drawing.Color.White;
            this.txtid.HintForeColor = System.Drawing.Color.Empty;
            this.txtid.HintText = "";
            this.txtid.isPassword = false;
            this.txtid.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtid.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtid.LineThickness = 3;
            this.txtid.Location = new System.Drawing.Point(13, 236);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(297, 44);
            this.txtid.TabIndex = 7;
            this.txtid.Text = "qasimmehmood13936@gmail.com";
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtid.OnValueChanged += new System.EventHandler(this.txtid_OnValueChanged);
            this.txtid.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtid.Leave += new System.EventHandler(this.txtid_Leave);
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
            this.txtpassword.Location = new System.Drawing.Point(13, 302);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(297, 44);
            this.txtpassword.TabIndex = 8;
            this.txtpassword.Text = "Allahis1!";
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.OnValueChanged += new System.EventHandler(this.txtpassword_OnValueChanged);
            this.txtpassword.Enter += new System.EventHandler(this.txtpassword_Enter);
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(333, 498);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblsignup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuThinButton2 btnlogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsignup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuMaterialTextbox txtpassword;
        private ns1.BunifuMaterialTextbox txtid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}