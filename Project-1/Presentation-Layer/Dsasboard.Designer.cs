namespace Project_1.Presentation_Layer
{
    partial class Dsasboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dsasboard));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnstudent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnroom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnarrangement = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnadmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelarrangement = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnsavearrangement = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnArrange = new Bunifu.Framework.UI.BunifuFlatButton();
            this.listroom = new System.Windows.Forms.ListBox();
            this.btnselectroom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.droproom = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtarrangement = new ns1.BunifuMaterialTextbox();
            this.panelstudent = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dropsheet = new System.Windows.Forms.ComboBox();
            this.dropsheet2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtfilepath = new ns1.BunifuMaterialTextbox();
            this.btnloadfile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.grideviewsheet = new ns1.BunifuCustomDataGrid();
            this.btnsavestudents = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtclasss = new ns1.BunifuMaterialTextbox();
            this.txtsubjectcode = new ns1.BunifuMaterialTextbox();
            this.txtsubject = new ns1.BunifuMaterialTextbox();
            this.droparrangement = new Bunifu.Framework.UI.BunifuDropdown();
            this.panalroom = new System.Windows.Forms.Panel();
            this.txtallowedseats = new ns1.BunifuMaterialTextbox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnsaverooms = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txttotal = new ns1.BunifuMaterialTextbox();
            this.txtcol = new ns1.BunifuMaterialTextbox();
            this.txtrow = new ns1.BunifuMaterialTextbox();
            this.txtroomnumber = new ns1.BunifuMaterialTextbox();
            this.panelsetting = new System.Windows.Forms.Panel();
            this.btnsaveadmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtconfpassword = new ns1.BunifuMaterialTextbox();
            this.txtpassword = new ns1.BunifuMaterialTextbox();
            this.txtemail = new ns1.BunifuMaterialTextbox();
            this.txtlname = new ns1.BunifuMaterialTextbox();
            this.txtfname = new ns1.BunifuMaterialTextbox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelarrangement.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelstudent.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grideviewsheet)).BeginInit();
            this.panel10.SuspendLayout();
            this.panalroom.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelsetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnstudent);
            this.panel1.Controls.Add(this.btnroom);
            this.panel1.Controls.Add(this.btnarrangement);
            this.panel1.Controls.Add(this.btnadmin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 420);
            this.panel1.TabIndex = 0;
            // 
            // btnstudent
            // 
            this.btnstudent.Active = false;
            this.btnstudent.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnstudent.BackColor = System.Drawing.Color.Black;
            this.btnstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstudent.BorderRadius = 1;
            this.btnstudent.ButtonText = "Add Students";
            this.btnstudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstudent.DisabledColor = System.Drawing.Color.Gray;
            this.btnstudent.Iconcolor = System.Drawing.Color.Transparent;
            this.btnstudent.Iconimage = global::Project_1.Properties.Resources.student;
            this.btnstudent.Iconimage_right = null;
            this.btnstudent.Iconimage_right_Selected = null;
            this.btnstudent.Iconimage_Selected = null;
            this.btnstudent.IconMarginLeft = 0;
            this.btnstudent.IconMarginRight = 0;
            this.btnstudent.IconRightVisible = true;
            this.btnstudent.IconRightZoom = 0D;
            this.btnstudent.IconVisible = true;
            this.btnstudent.IconZoom = 50D;
            this.btnstudent.IsTab = false;
            this.btnstudent.Location = new System.Drawing.Point(0, 224);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Normalcolor = System.Drawing.Color.Black;
            this.btnstudent.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnstudent.OnHoverTextColor = System.Drawing.Color.White;
            this.btnstudent.selected = false;
            this.btnstudent.Size = new System.Drawing.Size(200, 42);
            this.btnstudent.TabIndex = 10;
            this.btnstudent.Text = "Add Students";
            this.btnstudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstudent.Textcolor = System.Drawing.Color.White;
            this.btnstudent.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btnroom
            // 
            this.btnroom.Active = false;
            this.btnroom.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnroom.BackColor = System.Drawing.Color.Black;
            this.btnroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnroom.BorderRadius = 1;
            this.btnroom.ButtonText = "Create Room / Hall";
            this.btnroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnroom.DisabledColor = System.Drawing.Color.Gray;
            this.btnroom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnroom.Iconimage = global::Project_1.Properties.Resources.room;
            this.btnroom.Iconimage_right = null;
            this.btnroom.Iconimage_right_Selected = null;
            this.btnroom.Iconimage_Selected = null;
            this.btnroom.IconMarginLeft = 0;
            this.btnroom.IconMarginRight = 0;
            this.btnroom.IconRightVisible = true;
            this.btnroom.IconRightZoom = 0D;
            this.btnroom.IconVisible = true;
            this.btnroom.IconZoom = 50D;
            this.btnroom.IsTab = false;
            this.btnroom.Location = new System.Drawing.Point(0, 176);
            this.btnroom.Name = "btnroom";
            this.btnroom.Normalcolor = System.Drawing.Color.Black;
            this.btnroom.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnroom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnroom.selected = false;
            this.btnroom.Size = new System.Drawing.Size(200, 42);
            this.btnroom.TabIndex = 9;
            this.btnroom.Text = "Create Room / Hall";
            this.btnroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroom.Textcolor = System.Drawing.Color.White;
            this.btnroom.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroom.Click += new System.EventHandler(this.btnroom_Click);
            // 
            // btnarrangement
            // 
            this.btnarrangement.Active = false;
            this.btnarrangement.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnarrangement.BackColor = System.Drawing.Color.Black;
            this.btnarrangement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnarrangement.BorderRadius = 1;
            this.btnarrangement.ButtonText = "Create Arrangement / Event";
            this.btnarrangement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnarrangement.DisabledColor = System.Drawing.Color.Gray;
            this.btnarrangement.Iconcolor = System.Drawing.Color.Transparent;
            this.btnarrangement.Iconimage = global::Project_1.Properties.Resources._event;
            this.btnarrangement.Iconimage_right = null;
            this.btnarrangement.Iconimage_right_Selected = null;
            this.btnarrangement.Iconimage_Selected = null;
            this.btnarrangement.IconMarginLeft = 0;
            this.btnarrangement.IconMarginRight = 0;
            this.btnarrangement.IconRightVisible = true;
            this.btnarrangement.IconRightZoom = 0D;
            this.btnarrangement.IconVisible = true;
            this.btnarrangement.IconZoom = 60D;
            this.btnarrangement.IsTab = false;
            this.btnarrangement.Location = new System.Drawing.Point(0, 128);
            this.btnarrangement.Name = "btnarrangement";
            this.btnarrangement.Normalcolor = System.Drawing.Color.Black;
            this.btnarrangement.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnarrangement.OnHoverTextColor = System.Drawing.Color.White;
            this.btnarrangement.selected = false;
            this.btnarrangement.Size = new System.Drawing.Size(200, 42);
            this.btnarrangement.TabIndex = 8;
            this.btnarrangement.Text = "Create Arrangement / Event";
            this.btnarrangement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnarrangement.Textcolor = System.Drawing.Color.White;
            this.btnarrangement.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnarrangement.Click += new System.EventHandler(this.btnarrangement_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.Active = false;
            this.btnadmin.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnadmin.BackColor = System.Drawing.Color.Black;
            this.btnadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadmin.BorderRadius = 1;
            this.btnadmin.ButtonText = "Setting";
            this.btnadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnadmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnadmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnadmin.Iconimage")));
            this.btnadmin.Iconimage_right = null;
            this.btnadmin.Iconimage_right_Selected = null;
            this.btnadmin.Iconimage_Selected = null;
            this.btnadmin.IconMarginLeft = 0;
            this.btnadmin.IconMarginRight = 0;
            this.btnadmin.IconRightVisible = true;
            this.btnadmin.IconRightZoom = 0D;
            this.btnadmin.IconVisible = true;
            this.btnadmin.IconZoom = 50D;
            this.btnadmin.IsTab = false;
            this.btnadmin.Location = new System.Drawing.Point(0, 80);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Normalcolor = System.Drawing.Color.Black;
            this.btnadmin.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnadmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnadmin.selected = false;
            this.btnadmin.Size = new System.Drawing.Size(200, 42);
            this.btnadmin.TabIndex = 7;
            this.btnadmin.Text = "Setting";
            this.btnadmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmin.Textcolor = System.Drawing.Color.White;
            this.btnadmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 30);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelarrangement
            // 
            this.panelarrangement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panelarrangement.Controls.Add(this.panel4);
            this.panelarrangement.Controls.Add(this.listroom);
            this.panelarrangement.Controls.Add(this.btnselectroom);
            this.panelarrangement.Controls.Add(this.droproom);
            this.panelarrangement.Controls.Add(this.txtarrangement);
            this.panelarrangement.Location = new System.Drawing.Point(441, 158);
            this.panelarrangement.Name = "panelarrangement";
            this.panelarrangement.Padding = new System.Windows.Forms.Padding(50);
            this.panelarrangement.Size = new System.Drawing.Size(600, 420);
            this.panelarrangement.TabIndex = 11;
            this.panelarrangement.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnsavearrangement);
            this.panel4.Controls.Add(this.btnArrange);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(50, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 53);
            this.panel4.TabIndex = 14;
            // 
            // btnsavearrangement
            // 
            this.btnsavearrangement.Active = false;
            this.btnsavearrangement.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnsavearrangement.BackColor = System.Drawing.Color.DarkOrange;
            this.btnsavearrangement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsavearrangement.BorderRadius = 0;
            this.btnsavearrangement.ButtonText = "Save";
            this.btnsavearrangement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsavearrangement.DisabledColor = System.Drawing.Color.Goldenrod;
            this.btnsavearrangement.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnsavearrangement.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsavearrangement.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsavearrangement.Iconimage")));
            this.btnsavearrangement.Iconimage_right = null;
            this.btnsavearrangement.Iconimage_right_Selected = null;
            this.btnsavearrangement.Iconimage_Selected = null;
            this.btnsavearrangement.IconMarginLeft = 0;
            this.btnsavearrangement.IconMarginRight = 0;
            this.btnsavearrangement.IconRightVisible = true;
            this.btnsavearrangement.IconRightZoom = 0D;
            this.btnsavearrangement.IconVisible = true;
            this.btnsavearrangement.IconZoom = 90D;
            this.btnsavearrangement.IsTab = false;
            this.btnsavearrangement.Location = new System.Drawing.Point(0, 0);
            this.btnsavearrangement.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnsavearrangement.Name = "btnsavearrangement";
            this.btnsavearrangement.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnsavearrangement.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.btnsavearrangement.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsavearrangement.Padding = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.btnsavearrangement.selected = false;
            this.btnsavearrangement.Size = new System.Drawing.Size(236, 53);
            this.btnsavearrangement.TabIndex = 11;
            this.btnsavearrangement.Text = "Save";
            this.btnsavearrangement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsavearrangement.Textcolor = System.Drawing.Color.White;
            this.btnsavearrangement.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavearrangement.Click += new System.EventHandler(this.btnsavearrangement_Click);
            // 
            // btnArrange
            // 
            this.btnArrange.Active = false;
            this.btnArrange.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnArrange.BackColor = System.Drawing.Color.DarkOrange;
            this.btnArrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArrange.BorderRadius = 0;
            this.btnArrange.ButtonText = "Arrange";
            this.btnArrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrange.DisabledColor = System.Drawing.Color.Goldenrod;
            this.btnArrange.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnArrange.Iconcolor = System.Drawing.Color.Transparent;
            this.btnArrange.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnArrange.Iconimage")));
            this.btnArrange.Iconimage_right = null;
            this.btnArrange.Iconimage_right_Selected = null;
            this.btnArrange.Iconimage_Selected = null;
            this.btnArrange.IconMarginLeft = 0;
            this.btnArrange.IconMarginRight = 0;
            this.btnArrange.IconRightVisible = true;
            this.btnArrange.IconRightZoom = 0D;
            this.btnArrange.IconVisible = true;
            this.btnArrange.IconZoom = 90D;
            this.btnArrange.IsTab = false;
            this.btnArrange.Location = new System.Drawing.Point(253, 0);
            this.btnArrange.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnArrange.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.btnArrange.OnHoverTextColor = System.Drawing.Color.White;
            this.btnArrange.Padding = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.btnArrange.selected = false;
            this.btnArrange.Size = new System.Drawing.Size(247, 53);
            this.btnArrange.TabIndex = 10;
            this.btnArrange.Text = "Arrange";
            this.btnArrange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArrange.Textcolor = System.Drawing.Color.White;
            this.btnArrange.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // listroom
            // 
            this.listroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.listroom.FormattingEnabled = true;
            this.listroom.Location = new System.Drawing.Point(50, 177);
            this.listroom.Name = "listroom";
            this.listroom.Size = new System.Drawing.Size(500, 134);
            this.listroom.TabIndex = 13;
            // 
            // btnselectroom
            // 
            this.btnselectroom.Active = false;
            this.btnselectroom.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnselectroom.BackColor = System.Drawing.Color.DarkOrange;
            this.btnselectroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnselectroom.BorderRadius = 0;
            this.btnselectroom.ButtonText = "Select Room";
            this.btnselectroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnselectroom.DisabledColor = System.Drawing.Color.Gray;
            this.btnselectroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnselectroom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnselectroom.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnselectroom.Iconimage")));
            this.btnselectroom.Iconimage_right = null;
            this.btnselectroom.Iconimage_right_Selected = null;
            this.btnselectroom.Iconimage_Selected = null;
            this.btnselectroom.IconMarginLeft = 0;
            this.btnselectroom.IconMarginRight = 0;
            this.btnselectroom.IconRightVisible = true;
            this.btnselectroom.IconRightZoom = 0D;
            this.btnselectroom.IconVisible = true;
            this.btnselectroom.IconZoom = 90D;
            this.btnselectroom.IsTab = false;
            this.btnselectroom.Location = new System.Drawing.Point(50, 154);
            this.btnselectroom.Name = "btnselectroom";
            this.btnselectroom.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnselectroom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.btnselectroom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnselectroom.Padding = new System.Windows.Forms.Padding(20);
            this.btnselectroom.selected = false;
            this.btnselectroom.Size = new System.Drawing.Size(500, 23);
            this.btnselectroom.TabIndex = 12;
            this.btnselectroom.Text = "Select Room";
            this.btnselectroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnselectroom.Textcolor = System.Drawing.Color.White;
            this.btnselectroom.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselectroom.Click += new System.EventHandler(this.btnselectroom_Click);
            // 
            // droproom
            // 
            this.droproom.BackColor = System.Drawing.Color.Transparent;
            this.droproom.BorderRadius = 3;
            this.droproom.DisabledColor = System.Drawing.Color.Gray;
            this.droproom.Dock = System.Windows.Forms.DockStyle.Top;
            this.droproom.ForeColor = System.Drawing.Color.White;
            this.droproom.items = new string[0];
            this.droproom.Location = new System.Drawing.Point(50, 105);
            this.droproom.Name = "droproom";
            this.droproom.NomalColor = System.Drawing.Color.DarkOrange;
            this.droproom.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.droproom.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.droproom.selectedIndex = -1;
            this.droproom.Size = new System.Drawing.Size(500, 49);
            this.droproom.TabIndex = 11;
            this.droproom.onItemSelected += new System.EventHandler(this.droproom_onItemSelected);
            this.droproom.Enter += new System.EventHandler(this.droproom_Enter);
            // 
            // txtarrangement
            // 
            this.txtarrangement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtarrangement.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtarrangement.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtarrangement.ForeColor = System.Drawing.Color.White;
            this.txtarrangement.HintForeColor = System.Drawing.Color.Empty;
            this.txtarrangement.HintText = "";
            this.txtarrangement.isPassword = false;
            this.txtarrangement.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtarrangement.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtarrangement.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtarrangement.LineThickness = 3;
            this.txtarrangement.Location = new System.Drawing.Point(50, 50);
            this.txtarrangement.Margin = new System.Windows.Forms.Padding(0);
            this.txtarrangement.Name = "txtarrangement";
            this.txtarrangement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtarrangement.Size = new System.Drawing.Size(500, 55);
            this.txtarrangement.TabIndex = 5;
            this.txtarrangement.Text = "Arrangement / Event Name";
            this.txtarrangement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelstudent
            // 
            this.panelstudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panelstudent.Controls.Add(this.panel11);
            this.panelstudent.Controls.Add(this.panel9);
            this.panelstudent.Controls.Add(this.panel10);
            this.panelstudent.Controls.Add(this.droparrangement);
            this.panelstudent.Location = new System.Drawing.Point(356, 238);
            this.panelstudent.Name = "panelstudent";
            this.panelstudent.Padding = new System.Windows.Forms.Padding(50);
            this.panelstudent.Size = new System.Drawing.Size(600, 420);
            this.panelstudent.TabIndex = 13;
            this.panelstudent.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel11.Controls.Add(this.dropsheet);
            this.panel11.Controls.Add(this.dropsheet2);
            this.panel11.Controls.Add(this.txtfilepath);
            this.panel11.Controls.Add(this.btnloadfile);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(50, 150);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(5);
            this.panel11.Size = new System.Drawing.Size(500, 46);
            this.panel11.TabIndex = 20;
            // 
            // dropsheet
            // 
            this.dropsheet.FormattingEnabled = true;
            this.dropsheet.Location = new System.Drawing.Point(338, 13);
            this.dropsheet.Name = "dropsheet";
            this.dropsheet.Size = new System.Drawing.Size(157, 21);
            this.dropsheet.TabIndex = 9;
            this.dropsheet.SelectedIndexChanged += new System.EventHandler(this.dropsheet_SelectedIndexChanged);
            // 
            // dropsheet2
            // 
            this.dropsheet2.BackColor = System.Drawing.Color.Transparent;
            this.dropsheet2.BorderRadius = 3;
            this.dropsheet2.DisabledColor = System.Drawing.Color.Gray;
            this.dropsheet2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dropsheet2.ForeColor = System.Drawing.Color.White;
            this.dropsheet2.items = new string[0];
            this.dropsheet2.Location = new System.Drawing.Point(338, 5);
            this.dropsheet2.Name = "dropsheet2";
            this.dropsheet2.NomalColor = System.Drawing.Color.DarkOrange;
            this.dropsheet2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.dropsheet2.selectedIndex = -1;
            this.dropsheet2.Size = new System.Drawing.Size(157, 36);
            this.dropsheet2.TabIndex = 7;
            // 
            // txtfilepath
            // 
            this.txtfilepath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfilepath.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtfilepath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtfilepath.ForeColor = System.Drawing.Color.White;
            this.txtfilepath.HintForeColor = System.Drawing.Color.Empty;
            this.txtfilepath.HintText = "";
            this.txtfilepath.isPassword = false;
            this.txtfilepath.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtfilepath.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtfilepath.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtfilepath.LineThickness = 3;
            this.txtfilepath.Location = new System.Drawing.Point(108, 5);
            this.txtfilepath.Margin = new System.Windows.Forms.Padding(0);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Padding = new System.Windows.Forms.Padding(10, 0, 0, 5);
            this.txtfilepath.Size = new System.Drawing.Size(224, 36);
            this.txtfilepath.TabIndex = 6;
            this.txtfilepath.Text = "Subject Code";
            this.txtfilepath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnloadfile
            // 
            this.btnloadfile.Active = false;
            this.btnloadfile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnloadfile.BackColor = System.Drawing.Color.DarkOrange;
            this.btnloadfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnloadfile.BorderRadius = 0;
            this.btnloadfile.ButtonText = "    Load File";
            this.btnloadfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnloadfile.DisabledColor = System.Drawing.Color.Gray;
            this.btnloadfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnloadfile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnloadfile.Iconimage = null;
            this.btnloadfile.Iconimage_right = null;
            this.btnloadfile.Iconimage_right_Selected = null;
            this.btnloadfile.Iconimage_Selected = null;
            this.btnloadfile.IconMarginLeft = 0;
            this.btnloadfile.IconMarginRight = 0;
            this.btnloadfile.IconRightVisible = true;
            this.btnloadfile.IconRightZoom = 0D;
            this.btnloadfile.IconVisible = true;
            this.btnloadfile.IconZoom = 90D;
            this.btnloadfile.IsTab = false;
            this.btnloadfile.Location = new System.Drawing.Point(5, 5);
            this.btnloadfile.Name = "btnloadfile";
            this.btnloadfile.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnloadfile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.btnloadfile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnloadfile.selected = false;
            this.btnloadfile.Size = new System.Drawing.Size(103, 36);
            this.btnloadfile.TabIndex = 8;
            this.btnloadfile.Text = "    Load File";
            this.btnloadfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnloadfile.Textcolor = System.Drawing.Color.White;
            this.btnloadfile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadfile.Click += new System.EventHandler(this.btnloadfile_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.btnsavestudents);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(50, 150);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5);
            this.panel9.Size = new System.Drawing.Size(500, 220);
            this.panel9.TabIndex = 14;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.grideviewsheet);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(5, 52);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(490, 132);
            this.panel12.TabIndex = 12;
            // 
            // grideviewsheet
            // 
            this.grideviewsheet.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grideviewsheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grideviewsheet.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grideviewsheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grideviewsheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grideviewsheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grideviewsheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grideviewsheet.Dock = System.Windows.Forms.DockStyle.Top;
            this.grideviewsheet.DoubleBuffered = true;
            this.grideviewsheet.EnableHeadersVisualStyles = false;
            this.grideviewsheet.HeaderBgColor = System.Drawing.Color.DarkOrange;
            this.grideviewsheet.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.grideviewsheet.Location = new System.Drawing.Point(0, 0);
            this.grideviewsheet.Name = "grideviewsheet";
            this.grideviewsheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grideviewsheet.Size = new System.Drawing.Size(490, 126);
            this.grideviewsheet.TabIndex = 19;
            // 
            // btnsavestudents
            // 
            this.btnsavestudents.Active = false;
            this.btnsavestudents.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnsavestudents.BackColor = System.Drawing.Color.DarkOrange;
            this.btnsavestudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsavestudents.BorderRadius = 0;
            this.btnsavestudents.ButtonText = "Save";
            this.btnsavestudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsavestudents.DisabledColor = System.Drawing.Color.Goldenrod;
            this.btnsavestudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsavestudents.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsavestudents.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsavestudents.Iconimage")));
            this.btnsavestudents.Iconimage_right = null;
            this.btnsavestudents.Iconimage_right_Selected = null;
            this.btnsavestudents.Iconimage_Selected = null;
            this.btnsavestudents.IconMarginLeft = 0;
            this.btnsavestudents.IconMarginRight = 0;
            this.btnsavestudents.IconRightVisible = true;
            this.btnsavestudents.IconRightZoom = 0D;
            this.btnsavestudents.IconVisible = true;
            this.btnsavestudents.IconZoom = 90D;
            this.btnsavestudents.IsTab = false;
            this.btnsavestudents.Location = new System.Drawing.Point(5, 184);
            this.btnsavestudents.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnsavestudents.Name = "btnsavestudents";
            this.btnsavestudents.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnsavestudents.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.btnsavestudents.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsavestudents.Padding = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.btnsavestudents.selected = false;
            this.btnsavestudents.Size = new System.Drawing.Size(490, 31);
            this.btnsavestudents.TabIndex = 11;
            this.btnsavestudents.Text = "Save";
            this.btnsavestudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsavestudents.Textcolor = System.Drawing.Color.White;
            this.btnsavestudents.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavestudents.Click += new System.EventHandler(this.btnsavestudents_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel10.Controls.Add(this.txtclasss);
            this.panel10.Controls.Add(this.txtsubjectcode);
            this.panel10.Controls.Add(this.txtsubject);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(50, 85);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel10.Size = new System.Drawing.Size(500, 65);
            this.panel10.TabIndex = 15;
            // 
            // txtclasss
            // 
            this.txtclasss.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtclasss.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtclasss.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtclasss.ForeColor = System.Drawing.Color.White;
            this.txtclasss.HintForeColor = System.Drawing.Color.Empty;
            this.txtclasss.HintText = "";
            this.txtclasss.isPassword = false;
            this.txtclasss.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtclasss.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtclasss.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtclasss.LineThickness = 3;
            this.txtclasss.Location = new System.Drawing.Point(355, 0);
            this.txtclasss.Margin = new System.Windows.Forms.Padding(0);
            this.txtclasss.Name = "txtclasss";
            this.txtclasss.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.txtclasss.Size = new System.Drawing.Size(145, 55);
            this.txtclasss.TabIndex = 7;
            this.txtclasss.Text = "Class";
            this.txtclasss.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtsubjectcode
            // 
            this.txtsubjectcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsubjectcode.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtsubjectcode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsubjectcode.ForeColor = System.Drawing.Color.White;
            this.txtsubjectcode.HintForeColor = System.Drawing.Color.Empty;
            this.txtsubjectcode.HintText = "";
            this.txtsubjectcode.isPassword = false;
            this.txtsubjectcode.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtsubjectcode.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtsubjectcode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtsubjectcode.LineThickness = 3;
            this.txtsubjectcode.Location = new System.Drawing.Point(161, 0);
            this.txtsubjectcode.Margin = new System.Windows.Forms.Padding(0);
            this.txtsubjectcode.Name = "txtsubjectcode";
            this.txtsubjectcode.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.txtsubjectcode.Size = new System.Drawing.Size(176, 55);
            this.txtsubjectcode.TabIndex = 6;
            this.txtsubjectcode.Text = "Subject Code";
            this.txtsubjectcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtsubject
            // 
            this.txtsubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtsubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsubject.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtsubject.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsubject.ForeColor = System.Drawing.Color.White;
            this.txtsubject.HintForeColor = System.Drawing.Color.Empty;
            this.txtsubject.HintText = "";
            this.txtsubject.isPassword = false;
            this.txtsubject.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtsubject.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtsubject.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtsubject.LineThickness = 3;
            this.txtsubject.Location = new System.Drawing.Point(0, 0);
            this.txtsubject.Margin = new System.Windows.Forms.Padding(0);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.txtsubject.Size = new System.Drawing.Size(161, 55);
            this.txtsubject.TabIndex = 5;
            this.txtsubject.Text = "Subject";
            this.txtsubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // droparrangement
            // 
            this.droparrangement.BackColor = System.Drawing.Color.Transparent;
            this.droparrangement.BorderRadius = 3;
            this.droparrangement.DisabledColor = System.Drawing.Color.Gray;
            this.droparrangement.Dock = System.Windows.Forms.DockStyle.Top;
            this.droparrangement.ForeColor = System.Drawing.Color.White;
            this.droparrangement.items = new string[0];
            this.droparrangement.Location = new System.Drawing.Point(50, 50);
            this.droparrangement.Name = "droparrangement";
            this.droparrangement.NomalColor = System.Drawing.Color.DarkOrange;
            this.droparrangement.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.droparrangement.selectedIndex = -1;
            this.droparrangement.Size = new System.Drawing.Size(500, 35);
            this.droparrangement.TabIndex = 18;
            this.droparrangement.Enter += new System.EventHandler(this.droparrangement_Enter);
            // 
            // panalroom
            // 
            this.panalroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panalroom.Controls.Add(this.txtallowedseats);
            this.panalroom.Controls.Add(this.panel6);
            this.panalroom.Controls.Add(this.panel7);
            this.panalroom.Controls.Add(this.txtroomnumber);
            this.panalroom.Location = new System.Drawing.Point(271, 358);
            this.panalroom.Name = "panalroom";
            this.panalroom.Padding = new System.Windows.Forms.Padding(50);
            this.panalroom.Size = new System.Drawing.Size(600, 420);
            this.panalroom.TabIndex = 12;
            this.panalroom.Visible = false;
            // 
            // txtallowedseats
            // 
            this.txtallowedseats.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtallowedseats.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtallowedseats.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtallowedseats.ForeColor = System.Drawing.Color.White;
            this.txtallowedseats.HintForeColor = System.Drawing.Color.Empty;
            this.txtallowedseats.HintText = "";
            this.txtallowedseats.isPassword = false;
            this.txtallowedseats.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtallowedseats.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtallowedseats.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtallowedseats.LineThickness = 3;
            this.txtallowedseats.Location = new System.Drawing.Point(50, 176);
            this.txtallowedseats.Margin = new System.Windows.Forms.Padding(0);
            this.txtallowedseats.Name = "txtallowedseats";
            this.txtallowedseats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtallowedseats.Size = new System.Drawing.Size(500, 55);
            this.txtallowedseats.TabIndex = 17;
            this.txtallowedseats.Text = "Allowed Seats";
            this.txtallowedseats.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnsaverooms);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(50, 317);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 53);
            this.panel6.TabIndex = 14;
            // 
            // btnsaverooms
            // 
            this.btnsaverooms.Active = false;
            this.btnsaverooms.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnsaverooms.BackColor = System.Drawing.Color.DarkOrange;
            this.btnsaverooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsaverooms.BorderRadius = 0;
            this.btnsaverooms.ButtonText = "Save";
            this.btnsaverooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsaverooms.DisabledColor = System.Drawing.Color.Goldenrod;
            this.btnsaverooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsaverooms.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsaverooms.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsaverooms.Iconimage")));
            this.btnsaverooms.Iconimage_right = null;
            this.btnsaverooms.Iconimage_right_Selected = null;
            this.btnsaverooms.Iconimage_Selected = null;
            this.btnsaverooms.IconMarginLeft = 0;
            this.btnsaverooms.IconMarginRight = 0;
            this.btnsaverooms.IconRightVisible = true;
            this.btnsaverooms.IconRightZoom = 0D;
            this.btnsaverooms.IconVisible = true;
            this.btnsaverooms.IconZoom = 90D;
            this.btnsaverooms.IsTab = false;
            this.btnsaverooms.Location = new System.Drawing.Point(0, 0);
            this.btnsaverooms.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnsaverooms.Name = "btnsaverooms";
            this.btnsaverooms.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnsaverooms.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.btnsaverooms.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsaverooms.Padding = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.btnsaverooms.selected = false;
            this.btnsaverooms.Size = new System.Drawing.Size(500, 53);
            this.btnsaverooms.TabIndex = 11;
            this.btnsaverooms.Text = "Save";
            this.btnsaverooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaverooms.Textcolor = System.Drawing.Color.White;
            this.btnsaverooms.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaverooms.Click += new System.EventHandler(this.btnsaverooms_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel7.Controls.Add(this.txttotal);
            this.panel7.Controls.Add(this.txtcol);
            this.panel7.Controls.Add(this.txtrow);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(50, 105);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(500, 71);
            this.panel7.TabIndex = 15;
            // 
            // txttotal
            // 
            this.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.txttotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txttotal.ForeColor = System.Drawing.Color.White;
            this.txttotal.HintForeColor = System.Drawing.Color.Empty;
            this.txttotal.HintText = "";
            this.txttotal.isPassword = false;
            this.txttotal.LineFocusedColor = System.Drawing.Color.Blue;
            this.txttotal.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txttotal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txttotal.LineThickness = 3;
            this.txttotal.Location = new System.Drawing.Point(337, 0);
            this.txttotal.Margin = new System.Windows.Forms.Padding(0);
            this.txttotal.Name = "txttotal";
            this.txttotal.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.txttotal.Size = new System.Drawing.Size(163, 71);
            this.txttotal.TabIndex = 7;
            this.txttotal.Text = "Total Seats";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcol
            // 
            this.txtcol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcol.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcol.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcol.ForeColor = System.Drawing.Color.White;
            this.txtcol.HintForeColor = System.Drawing.Color.Empty;
            this.txtcol.HintText = "";
            this.txtcol.isPassword = false;
            this.txtcol.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcol.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtcol.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcol.LineThickness = 3;
            this.txtcol.Location = new System.Drawing.Point(161, 0);
            this.txtcol.Margin = new System.Windows.Forms.Padding(0);
            this.txtcol.Name = "txtcol";
            this.txtcol.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.txtcol.Size = new System.Drawing.Size(176, 71);
            this.txtcol.TabIndex = 6;
            this.txtcol.Text = "Cols";
            this.txtcol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtrow
            // 
            this.txtrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtrow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrow.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtrow.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtrow.ForeColor = System.Drawing.Color.White;
            this.txtrow.HintForeColor = System.Drawing.Color.Empty;
            this.txtrow.HintText = "";
            this.txtrow.isPassword = false;
            this.txtrow.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtrow.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtrow.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtrow.LineThickness = 3;
            this.txtrow.Location = new System.Drawing.Point(0, 0);
            this.txtrow.Margin = new System.Windows.Forms.Padding(0);
            this.txtrow.Name = "txtrow";
            this.txtrow.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.txtrow.Size = new System.Drawing.Size(161, 71);
            this.txtrow.TabIndex = 5;
            this.txtrow.Text = "Rows";
            this.txtrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtroomnumber
            // 
            this.txtroomnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtroomnumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtroomnumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtroomnumber.ForeColor = System.Drawing.Color.White;
            this.txtroomnumber.HintForeColor = System.Drawing.Color.Empty;
            this.txtroomnumber.HintText = "";
            this.txtroomnumber.isPassword = false;
            this.txtroomnumber.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtroomnumber.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtroomnumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtroomnumber.LineThickness = 3;
            this.txtroomnumber.Location = new System.Drawing.Point(50, 50);
            this.txtroomnumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtroomnumber.Name = "txtroomnumber";
            this.txtroomnumber.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtroomnumber.Size = new System.Drawing.Size(500, 55);
            this.txtroomnumber.TabIndex = 16;
            this.txtroomnumber.Text = "RoomNumber";
            this.txtroomnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelsetting
            // 
            this.panelsetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panelsetting.Controls.Add(this.btnsaveadmin);
            this.panelsetting.Controls.Add(this.txtconfpassword);
            this.panelsetting.Controls.Add(this.txtpassword);
            this.panelsetting.Controls.Add(this.txtemail);
            this.panelsetting.Controls.Add(this.txtlname);
            this.panelsetting.Controls.Add(this.txtfname);
            this.panelsetting.Location = new System.Drawing.Point(557, 82);
            this.panelsetting.Name = "panelsetting";
            this.panelsetting.Padding = new System.Windows.Forms.Padding(50);
            this.panelsetting.Size = new System.Drawing.Size(604, 420);
            this.panelsetting.TabIndex = 0;
            // 
            // btnsaveadmin
            // 
            this.btnsaveadmin.Active = false;
            this.btnsaveadmin.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnsaveadmin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnsaveadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsaveadmin.BorderRadius = 0;
            this.btnsaveadmin.ButtonText = "Save";
            this.btnsaveadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsaveadmin.DisabledColor = System.Drawing.Color.Goldenrod;
            this.btnsaveadmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnsaveadmin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveadmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsaveadmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsaveadmin.Iconimage")));
            this.btnsaveadmin.Iconimage_right = null;
            this.btnsaveadmin.Iconimage_right_Selected = null;
            this.btnsaveadmin.Iconimage_Selected = null;
            this.btnsaveadmin.IconMarginLeft = 0;
            this.btnsaveadmin.IconMarginRight = 0;
            this.btnsaveadmin.IconRightVisible = true;
            this.btnsaveadmin.IconRightZoom = 0D;
            this.btnsaveadmin.IconVisible = true;
            this.btnsaveadmin.IconZoom = 90D;
            this.btnsaveadmin.IsTab = false;
            this.btnsaveadmin.Location = new System.Drawing.Point(313, 325);
            this.btnsaveadmin.Margin = new System.Windows.Forms.Padding(0);
            this.btnsaveadmin.Name = "btnsaveadmin";
            this.btnsaveadmin.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnsaveadmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.btnsaveadmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsaveadmin.selected = false;
            this.btnsaveadmin.Size = new System.Drawing.Size(241, 45);
            this.btnsaveadmin.TabIndex = 10;
            this.btnsaveadmin.Text = "Save";
            this.btnsaveadmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaveadmin.Textcolor = System.Drawing.Color.White;
            this.btnsaveadmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveadmin.Click += new System.EventHandler(this.btnsaveadmin_Click);
            // 
            // txtconfpassword
            // 
            this.txtconfpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconfpassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtconfpassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtconfpassword.ForeColor = System.Drawing.Color.White;
            this.txtconfpassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtconfpassword.HintText = "";
            this.txtconfpassword.isPassword = false;
            this.txtconfpassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtconfpassword.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtconfpassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtconfpassword.LineThickness = 3;
            this.txtconfpassword.Location = new System.Drawing.Point(50, 270);
            this.txtconfpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 20);
            this.txtconfpassword.Name = "txtconfpassword";
            this.txtconfpassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtconfpassword.Size = new System.Drawing.Size(504, 55);
            this.txtconfpassword.TabIndex = 6;
            this.txtconfpassword.Text = "Confirm Password";
            this.txtconfpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtconfpassword.OnValueChanged += new System.EventHandler(this.txtconfpassword_OnValueChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpassword.ForeColor = System.Drawing.Color.White;
            this.txtpassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtpassword.HintText = "";
            this.txtpassword.isPassword = false;
            this.txtpassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtpassword.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtpassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtpassword.LineThickness = 3;
            this.txtpassword.Location = new System.Drawing.Point(50, 215);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 20);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtpassword.Size = new System.Drawing.Size(504, 55);
            this.txtpassword.TabIndex = 8;
            this.txtpassword.Text = "Password";
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.OnValueChanged += new System.EventHandler(this.txtpassword_OnValueChanged);
            // 
            // txtemail
            // 
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtemail.ForeColor = System.Drawing.Color.White;
            this.txtemail.HintForeColor = System.Drawing.Color.Empty;
            this.txtemail.HintText = "";
            this.txtemail.isPassword = false;
            this.txtemail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtemail.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtemail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtemail.LineThickness = 3;
            this.txtemail.Location = new System.Drawing.Point(50, 160);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 20);
            this.txtemail.Name = "txtemail";
            this.txtemail.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtemail.Size = new System.Drawing.Size(504, 55);
            this.txtemail.TabIndex = 9;
            this.txtemail.Text = "Email";
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtemail.OnValueChanged += new System.EventHandler(this.txtemail_OnValueChanged);
            // 
            // txtlname
            // 
            this.txtlname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtlname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtlname.ForeColor = System.Drawing.Color.White;
            this.txtlname.HintForeColor = System.Drawing.Color.Empty;
            this.txtlname.HintText = "";
            this.txtlname.isPassword = false;
            this.txtlname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtlname.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtlname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtlname.LineThickness = 3;
            this.txtlname.Location = new System.Drawing.Point(50, 105);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 20);
            this.txtlname.Name = "txtlname";
            this.txtlname.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtlname.Size = new System.Drawing.Size(504, 55);
            this.txtlname.TabIndex = 7;
            this.txtlname.Text = "Last Name";
            this.txtlname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtlname.OnValueChanged += new System.EventHandler(this.txtlname_OnValueChanged_1);
            // 
            // txtfname
            // 
            this.txtfname.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtfname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtfname.ForeColor = System.Drawing.Color.White;
            this.txtfname.HintForeColor = System.Drawing.Color.Empty;
            this.txtfname.HintText = "";
            this.txtfname.isPassword = false;
            this.txtfname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtfname.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtfname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtfname.LineThickness = 3;
            this.txtfname.Location = new System.Drawing.Point(50, 50);
            this.txtfname.Margin = new System.Windows.Forms.Padding(0);
            this.txtfname.Name = "txtfname";
            this.txtfname.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtfname.Size = new System.Drawing.Size(504, 55);
            this.txtfname.TabIndex = 5;
            this.txtfname.Text = "First Name";
            this.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtfname.OnValueChanged += new System.EventHandler(this.txtfname_OnValueChanged_1);
            // 
            // Dsasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelsetting);
            this.Controls.Add(this.panelarrangement);
            this.Controls.Add(this.panelstudent);
            this.Controls.Add(this.panalroom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dsasboard";
            this.Text = "Dsasboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelarrangement.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelstudent.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grideviewsheet)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panalroom.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panelsetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnstudent;
        private Bunifu.Framework.UI.BunifuFlatButton btnroom;
        private Bunifu.Framework.UI.BunifuFlatButton btnarrangement;
        private Bunifu.Framework.UI.BunifuFlatButton btnadmin;
        private System.Windows.Forms.Panel panelsetting;
        private Bunifu.Framework.UI.BunifuFlatButton btnsaveadmin;
        private ns1.BunifuMaterialTextbox txtconfpassword;
        private ns1.BunifuMaterialTextbox txtpassword;
        private ns1.BunifuMaterialTextbox txtemail;
        private ns1.BunifuMaterialTextbox txtlname;
        private ns1.BunifuMaterialTextbox txtfname;
        private System.Windows.Forms.Panel panalroom;
        private ns1.BunifuMaterialTextbox txtallowedseats;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton btnsaverooms;
        private System.Windows.Forms.Panel panel7;
        private ns1.BunifuMaterialTextbox txttotal;
        private ns1.BunifuMaterialTextbox txtcol;
        private ns1.BunifuMaterialTextbox txtrow;
        private ns1.BunifuMaterialTextbox txtroomnumber;
        private System.Windows.Forms.Panel panelstudent;
        private System.Windows.Forms.Panel panel11;
        private Bunifu.Framework.UI.BunifuDropdown dropsheet2;
        private ns1.BunifuMaterialTextbox txtfilepath;
        private Bunifu.Framework.UI.BunifuFlatButton btnloadfile;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private ns1.BunifuCustomDataGrid grideviewsheet;
        private Bunifu.Framework.UI.BunifuFlatButton btnsavestudents;
        private System.Windows.Forms.Panel panel10;
        private ns1.BunifuMaterialTextbox txtclasss;
        private ns1.BunifuMaterialTextbox txtsubjectcode;
        private ns1.BunifuMaterialTextbox txtsubject;
        private Bunifu.Framework.UI.BunifuDropdown droparrangement;
        private System.Windows.Forms.Panel panelarrangement;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnsavearrangement;
        private Bunifu.Framework.UI.BunifuFlatButton btnArrange;
        private System.Windows.Forms.ListBox listroom;
        private Bunifu.Framework.UI.BunifuFlatButton btnselectroom;
        private Bunifu.Framework.UI.BunifuDropdown droproom;
        private ns1.BunifuMaterialTextbox txtarrangement;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox dropsheet;
    }
}