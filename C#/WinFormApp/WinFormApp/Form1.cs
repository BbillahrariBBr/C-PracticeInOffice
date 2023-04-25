using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wpfUc = Uc;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWinform_Click(object sender, EventArgs e)
        {
            wpfUc.user userControl= elementUC.Child as wpfUc.user;
            MessageBox.Show("wpf btn caption " + userControl.btn.Content + "wpf tbx text " + userControl.tbx.Text);
        }
    }
}
