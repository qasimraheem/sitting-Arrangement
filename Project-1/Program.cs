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
            Application.Run(new Dashboard(admin));
        }
    }//here is me
}
