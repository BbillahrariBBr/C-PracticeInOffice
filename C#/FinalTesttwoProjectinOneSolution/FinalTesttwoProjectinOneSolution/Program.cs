using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTesttwoProjectinOneSolution
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            frmMain form = new frmMain();
            Application.EnableVisualStyles();

            if (form.Visible == true)
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
            
            
        }
    }
}
