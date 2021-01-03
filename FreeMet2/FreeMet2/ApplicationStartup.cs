using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace FreeMet2
{
    public class ApplicationStartup : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            CheckSingleInstance();
        }

        private void CheckSingleInstance()
        {
            var singleInstanceMutex = new Mutex(true, this.MainWindow.Name, out bool singleInstance);
            if(!singleInstance)
            {
                return;
            }

            KillProcess();
        }

        private void KillProcess()
        {

        }
    }
}