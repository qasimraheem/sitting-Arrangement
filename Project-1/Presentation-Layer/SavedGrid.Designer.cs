namespace Project_1.Presentation_Layer
{
    partial class SavedGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.savedgrideviewsheet = new ns1.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.savedgrideviewsheet)).BeginInit();
            this.SuspendLayout();
            // 
            // savedgrideviewsheet
            // 
            this.savedgrideviewsheet.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.savedgrideviewsheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.savedgrideviewsheet.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.savedgrideviewsheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedgrideviewsheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.savedgrideviewsheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.savedgrideviewsheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.savedgrideviewsheet.DoubleBuffered = true;
            this.savedgrideviewsheet.EnableHeadersVisualStyles = false;
            this.savedgrideviewsheet.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.savedgrideviewsheet.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.savedgrideviewsheet.Location = new System.Drawing.Point(26, 36);
            this.savedgrideviewsheet.Name = "savedgrideviewsheet";
            this.savedgrideviewsheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.savedgrideviewsheet.Size = new System.Drawing.Size(745, 381);
            this.savedgrideviewsheet.TabIndex = 1;
            this.savedgrideviewsheet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grideviewsheet_CellContentClick);
            // 
            // SavedGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savedgrideviewsheet);
            this.Name = "SavedGrid";
            this.Text = "SavedGrid";
            this.Load += new System.EventHandler(this.SavedGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.savedgrideviewsheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCustomDataGrid savedgrideviewsheet;
    }
}