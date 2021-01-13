using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyrimBatchBuilder
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            File.Create("ProfileCreation.log").Close();
            File.Create("ListReader.log").Close(); 
            File.Create("ProfileBatBuilder.log").Close();
            Directory.CreateDirectory(@".\Resources\PerkList");
            Directory.CreateDirectory(@".\Profiles\Output");
            Directory.CreateDirectory(@".\Profiles\Overload");

            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("profilesfolder");
            config.AppSettings.Settings.Remove("resourcesfolder");
            config.AppSettings.Settings.Add("profilesfolder", @".\Profiles\");
            config.AppSettings.Settings.Add("resourcesfolder", @".\Resources\");
            if (File.Exists(@"..\SSEEdit.exe"))
            {
                config.AppSettings.Settings.Remove("sseedit");
                config.AppSettings.Settings.Add("sseedit", Path.GetFullPath(@"..\SSEEdit.exe").Replace(@"\SSEEdit.exe", ""));
            }
            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("appSettings");

            Application.Run(new MainForm());
        }
    }
}
