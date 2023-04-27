using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace FinalTesttwoProjectinOneSolution
{
    public partial class frmMain : Form
    {
        Window window;
        public frmMain()
        {
            this.Visible = false;
            Hide();
            InitializeComponent();
            //LoginUIWPF.LoginUI usercontrol = new LoginUIWPF.LoginUI();

            window = new Window
            {
                //Title = "WOW!!! working",
                Content = new LoginUIWPF.LoginUI(),
                Height = 470,
                Width = 780,
            };

            window.ShowDialog();
            Close();
            Dispose();
        }
    }
}
