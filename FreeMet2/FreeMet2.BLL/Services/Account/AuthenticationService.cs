using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeMet2.Utils;

namespace FreeMet2.BLL
{
    public class AuthenticationService : IAuthenticationService
    {
        public void LoginAccount(Action<string> action)
        {
            if (action == null) return;

            var result = HttpMethod.HttpGet(Constant.Root, Constant.testAddress);

            action(result);
        }

        public void LogoutAccount(Action<string> action)
        {
            if (action == null) return;

            var result = HttpMethod.HttpGet(Constant.Root, Constant.testAddress);

            action(result);
        }
    }
}
