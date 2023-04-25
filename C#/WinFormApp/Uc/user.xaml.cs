using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uc
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class user : UserControl
    {
        public Button btn;
        public TextBox tbx;

        public user()
        {
            InitializeComponent();
            btn = btnTest;
            tbx = tbxTest;
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Text=" + btnTest.Content + " tbx text=" + tbxTest.Text);
        }
    }
}
