using FreeMet2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FreeMet2.WinService
{
    public delegate void pLcb(bool status, string pcb);

    public class LoggerService : ILoggerService
    {
        private string _fileName;

        public void InitLog(string fileName)
        {
            this._fileName = fileName;
        }

        public void WriteLog(LogLevel level, pLcb pcb)
        {
            IntPtr ptr = Marshal.StringToHGlobalUni(_fileName);
            FmLogger.WriteLog(ptr, (int)level, pcb);
        }
    }
}
