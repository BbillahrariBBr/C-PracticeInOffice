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

namespace wpfProjectinWinForm
{
    public partial class frm_Home : Form
    {
        Window window;
        public frm_Home()
        {
            Hide();
            InitializeComponent();
            //WpfUserControl.UserControl1 usercontrol = new WpfUserControl.UserControl1();
            //LoginWpf.LoginUI login = new LoginWpf.LoginUI();
            window = new Window
            {
                Title = "My User Control Dialog",
                Content = new WpfUserControl.UserControl1()
            };
            window.ShowDialog();
            Close();

        }
    }
}
