using syncfusion.spreadsheetdemo.wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Syncfusion.SfSkinManager;

namespace Spreadsheet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            SfSkinManager.ApplyThemeAsDefaultStyle = true;
            var window = Activator.CreateInstance(typeof(SpreadSheetDemo)) as Window;
            window.Show();

            base.OnStartup(e);
        }
    }
}
