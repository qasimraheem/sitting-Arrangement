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

namespace Project_1.Presentation_Layer
{
    public partial class SavedGrid : Form
    {
        Matrix matrix=new Matrix();
        public SavedGrid(Matrix matrix)
        {
            InitializeComponent();
            this.matrix = matrix;
            //MessageBox.Show(matrix.room.roomNumber);
            this.Text = matrix.room.roomNumber;
           
        }

        private void grideviewsheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SavedGrid_Load(object sender, EventArgs e)
        {
            this.matrix.print();
            int height = this.matrix.row;
            int width = this.matrix.col;

            this.savedgrideviewsheet.ColumnCount = width;

            for(int i = 0; i < this.matrix.row; i++)// array rows
            {
                string[] row = new string[this.matrix.col];

                for(int j = 0; j < this.matrix.col; j++)
                {
                    row[j] = this.matrix.data[i, j].ToString();
                }

                savedgrideviewsheet.Rows.Add(row);
            }
        }
    }
}
