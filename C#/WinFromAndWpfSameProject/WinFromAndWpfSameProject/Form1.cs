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

namespace WinFromAndWpfSameProject
{
    public partial class Form1 : Form
    {
        Window window;


        public Form1()
        {
            this.Visible = false;
            InitializeComponent();
            //Hide();
            UserControl1 usercontrol = new UserControl1();
           
            window = new Window
            {
                Title = "My User Control Dialog",
                Content = new UserControl1()
            };

            window.ShowDialog();
            Close();
        }

        public Form1(bool doNotInvisible)
        {
            InitializeComponent();
        }
    }
}
