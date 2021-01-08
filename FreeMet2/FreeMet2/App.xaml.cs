using FreeMet2.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace FreeMet2
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            CheckSingleInstance();
        }

        private void CheckSingleInstance()
        {
            //new Mutex(true, this.MainWindow.Name, out bool singleInstance);
            //if (!singleInstance)
            //{
            //    return;
            //}

            KillProcess();
            CheckUserData();
        }

        private bool CheckUserData()
        {
            bool valid = false;

            string dir = Path.Combine(Environment.CurrentDirectory, ApplicationData.ConfigPath);
            string filePath = Path.Combine(dir, "FreeMet.ini");
            if (!File.Exists(filePath))
            {
                IniConfig.CreateIni(dir, "FreeMet.ini");
                return false;
            }

            ApplicationData.Instance.Token = IniConfig.Read("Token", "Token", "", filePath);
            int.TryParse(IniConfig.Read("ExpireTime", "ExpireTime", "", filePath), out int expire);
            ApplicationData.Instance.ExpireTime = expire;

            return valid;
        }

        private void KillProcess()
        {

        }
    }
}
