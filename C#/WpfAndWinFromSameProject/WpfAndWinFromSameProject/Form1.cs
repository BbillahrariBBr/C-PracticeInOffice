using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfAndWinFromSameProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {
            Hide();
            MainWindow mainWPf = new MainWindow(true);
            //mainWPf.Visibility = System.Windows.Visibility.Visible;
            mainWPf.ShowDialog();

            Close();
        }
    }
}
