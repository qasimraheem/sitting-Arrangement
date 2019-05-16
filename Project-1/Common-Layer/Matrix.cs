using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using Project_1.Common_Layer;
using Project_1.Presentation_Layer;
using Project_1.Data_Layer;
using System.Data.OleDb;


namespace Project_1.Common_Layer
{
    public class Matrix
    {

        public int row;
        public int col;
        public int[,] data;

        int rawcol = 0;
        int rawrow = 0;
        public int[,] rawdata;

        public Matrix()
        {

        }
        public Matrix(int row, int col)
        {
            this.col = col;
            this.row = row;
            this.data = new int [row,col];
        }
        public bool validate(int row,int col, int cms)
        {

            bool found=false;

            try {
                if (this.data[row -1,col - 1] == cms) {
                    found = true;
                }
               
            }
            catch (Exception) {

            }
            //try
            //{
            //    if (this.data[row - 1][col] == cms)
            //    {
            //        found = true;
            //    }

            //}
            //catch (Exception)
            //{

            //}
            try
            {
                if (this.data[row - 1,col + 1] == cms)
                {
                    found = true;
                }

            }
            catch (Exception)
            {

            }
            try
            {
                if (this.data[row,col - 1] == cms)
                {
                    found = true;
                }

            }
            catch (Exception)
            {

            }
            try
            {
                if (this.data[row,col + 1] == cms)
                {
                    found = true;
                }

            }
            catch (Exception)
            {

            }
            try
            {
                if (this.data[row + 1,col - 1] == cms)
                {
                    found = true;
                }

            }
            catch (Exception)
            {

            }
            //try
            //{
            //    if (this.data[row + 1][col] == cms)
            //    {
            //        found = true;
            //    }

            //}
            //catch (Exception)
            //{

            //}
            try
            {
                if (this.data[row + 1,col + 1] == cms)
                {
                    found = true;
                }

            }
            catch (Exception)
            {

            }

            if (found == true)
            {
                return false;
            }
            else return true;

        }

        //jhnjdcjza

        public void arrange(int[,] lists, int classes)
        {
            rawrow = lists.GetUpperBound(0) - lists.GetLowerBound(0) + 1;
            rawcol = lists.GetUpperBound(1) - lists.GetLowerBound(1) + 1;
            rawdata = new int[rawrow, rawcol];
            rawdata = lists;
            if (classes == 1)
            {
               // arrange1(lists, classes);
            }
            else if (classes == 2)
            {
               // arrange2(lists, classes);
            }
            else if (classes == 3)
            {
               // arrange3(lists, classes);
            }
            else if (classes == 4)
            {
               // arrange4(lists, classes);
            }
            else if (classes >= 5 && classes % 2 != 0)
            {
                arrangeManyOdd(lists, classes);
            }
            else if (classes >= 5 && classes % 2 == 0)
            {
                arrangeManyEven(lists, classes);
            }
            else {

            }
        }

        void arrange1(int[][] lists, int classes) {

            for (int j = 0; j < col; j++) {
                for (int i = 0; i < row; i++) {

                    foreach (int cms in lists[0]) {
                        if (cms != null && j % 2 == 0)
                        {
                            data[i,j] = cms;
                        }
                        else
                        {
                            data[i,j] = 0;
                        }
                    }
                    
                }
            }
        }
        void arrange2(int[][] lists, int classes)
        {
            int selectedCms = 0;
            int selectedRow = 0;
            int selectedCol = 0;
            bool complete = false;
            for (int j = 0; j < col; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    if (j != 0 || i != 0)
                    {

                        if ( selectedRow < lists.Length-1)
                        {
                            selectedRow++;
                        }
                        else {
                            selectedRow = 0;
                            if (lists[0].Length - 1 > selectedCol)
                            {
                                selectedCol++;
                            }
                            else {
                                complete=true;
                                break;
                            }
                        }
                        MessageBox.Show(selectedRow.ToString()+" and "+ selectedCol.ToString());

                        selectedCms = lists[selectedRow][selectedCol];

                        MessageBox.Show(selectedCms.ToString());

                        data[i,j]=selectedCms;
                    }
                    else {
                        selectedCms = lists[selectedRow][selectedCol];
                        MessageBox.Show(selectedCms.ToString());
                        data[i,j] = selectedCms;
                    }
                }
                if (complete) break;
            }
        }
        void arrange3(int[][] lists, int classes)
        {

        }
        void arrange4(int[][] lists, int classes)
        {

        }
        void arrangeManyOdd(int[,] lists , int classes)
        {
            int selectedCms = 0;
            int selectedRow = -1;
            int selectedCol = 0;
            bool complete = false;
            int preshift = 0;
            int nextshift = (rawrow / 2);
            MessageBox.Show("Next shift:" + nextshift);

            for (int j = 0; j < col; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    if (true)
                    {

                        if (selectedRow < rawrow-1)
                        {
                            selectedRow++;
                            for (int col = 0; col < rawcol; col++)
                            {
                                if (lists[selectedRow, col] != 0)
                                {
                                    selectedCol = col;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            selectedRow = 0;
                            if (rawcol-1 > selectedCol)
                            {
                                for (int col = 0; col < rawcol; col++) {
                                    if (lists[selectedRow, col] != 0) {
                                        selectedCol = col;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                complete = true;
                                break;
                            }
                        }
                        //MessageBox.Show(selectedRow.ToString() + " and " + selectedCol.ToString());

                        selectedCms = lists[selectedRow,selectedCol];

                       //MessageBox.Show(selectedCms.ToString());

                        data[i, j] = selectedCms;
                        lists[selectedRow, selectedCol] = 0;

                    }
                   
                }
                if (complete) break;

                //MessageBox.Show(nextshift.ToString());
                selectedRow = nextshift-1;
                preshift = nextshift;
                //MessageBox.Show("Next shift:"+selectedRow);
                nextshift = ((preshift + (rawrow / 2))%rawrow);
               
            }
        }
        void arrangeManyEven(int[,] lists, int classes)
        {
            bool toggle = true;
            int selectedCms = 0;
            int selectedRow = -1;
            int selectedCol = 0;
            bool complete = false;
            int preshift = 0;
            int nextshift = (rawrow / 2);
            MessageBox.Show("Next shift:" + nextshift);

            for (int j = 0; j < col; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    if (true)
                    {

                        if (selectedRow < rawrow - 1)
                        {
                            selectedRow++;
                            for (int col = 0; col < rawcol; col++)
                            {
                                if (lists[selectedRow, col] != 0)
                                {
                                    selectedCol = col;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            selectedRow = 0;
                            if (rawcol - 1 > selectedCol)
                            {
                                for (int col = 0; col < rawcol; col++)
                                {
                                    if (lists[selectedRow, col] != 0)
                                    {
                                        selectedCol = col;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                selectedRow = 0;
                                for (int col = 0; col < rawcol; col++)
                                {
                                    if (lists[selectedRow, col] != 0)
                                    {
                                        selectedCol = col;
                                        break;
                                    }
                                }
                                if (lists[selectedRow, selectedCol] == 0)
                                {
                                    complete = true;
                                    break;
                                }
                            }
                        }
                        //MessageBox.Show(selectedRow.ToString() + " and " + selectedCol.ToString());

                        selectedCms = lists[selectedRow, selectedCol];

                        //MessageBox.Show(selectedCms.ToString());

                        data[i, j] = selectedCms;
                        lists[selectedRow, selectedCol] = 0;

                    }

                }
                if (complete) break;

                //MessageBox.Show(nextshift.ToString());
                selectedRow = nextshift - 1;
                preshift = nextshift;
                if (toggle)
                {
                    nextshift = ((preshift + ((rawrow / 2) - 1)) % rawrow);
                    
                }
                else {
                    nextshift = ((preshift + ((rawrow / 2))) % rawrow);
                }
                toggle = toggle ? false : true;

               // MessageBox.Show("Next shift:" + nextshift);


            }
        }

        public void print() {
            string output="";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    output+=(data[i,j]).ToString();
                }
                output += "\r\n";
            }
            MessageBox.Show(output);

        }


        public void store() {
            Matrix matrix = new Matrix(row, col);
            matrix.data = this.data;
            SavedGrid savedGrid = new SavedGrid(matrix);
            
            savedGrid.Show();
        }


    }
}
