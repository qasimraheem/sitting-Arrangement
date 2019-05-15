using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Common_Layer
{
    class Matrix
    {
        int row;
        int col;
        string[][] data;

        public Matrix()
        {

        }
        public Matrix(int row, int col)
        {
            this.col = col;
            this.row = row;
        }


    }
}
