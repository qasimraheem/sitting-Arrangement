using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1.Presentation_Layer;
using Project_1.Common_Layer;
namespace Project_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Admin admin = new Admin();
            admin.email = "qasimmehmood13936@gmail.com";
            admin.last_name = "raheem";
            admin.first_name = "qasim";
            admin.password = "Allahis1!";
            admin.id = 1;
            Application.Run(new Login());
            //int[,] list = new int[8,8];

            //string ou = "";
            //for (int i = 0; i < 8; i++) {
            //    for (int j = 0; j < 8; j++) {
            //        list[i, j] = i+1;
               
            //    }
               
            //}
         
            ////string ou = "";
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        ou+=list[i,j];
            //    }
            //    ou += "\r\n";
            //}
            //MessageBox.Show(ou);
            //Matrix matrix = new Matrix(9,8);
            //matrix.arrange(list,8);
            //matrix.print();
           
        }
    }//here is me
}
