using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeMet2
{
    public class ApplicationData
    {
        public ApplicationData()
        {
            
        }
        private string _token;
        public string Token
        {
            get => _token;
            set => _token = value;
        }

        private DateTime _getTokenTime;
        public DateTime GetTokenTime
        {
            get => _getTokenTime;
            set => _getTokenTime = value;
        }

        private int _expireTime;
        public int ExpireTime
        {
            get => _expireTime;
            set => _expireTime = value;
        }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }
    }
}
