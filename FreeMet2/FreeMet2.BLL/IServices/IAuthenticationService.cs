using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeMet2.BLL
{
    public interface IAuthenticationService
    {
        void LoginAccount(Action<string> action);
        void LogoutAccount(Action<string> action);
    }
}
