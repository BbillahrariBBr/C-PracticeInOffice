using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MainAppSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            while(!CredentialHolder.Singleton.IsAuthenticated)
            {

            }
            if(CredentialHolder.Singleton.IsAuthenticated)
            {
                //SHow main window (may b add another Validatoions for feature control)
                var _mainWindow = new MainWindow();
                _mainWindow.ShowDialog();
            }

        }
    }
}
