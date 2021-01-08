using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeMet2
{
    public class ApplicationData
    {
        public const string ConfigPath = "FreeMet";

        private static ApplicationData _instance;
        public static ApplicationData Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ApplicationData();
                }
                return _instance;
            }
        }

        private string _uid;
        public string Uid
        {
            get => _uid;
            set => _uid = value;
        }

        public string _avatar;
        public string Avatar
        {
            get => _avatar;
            set => _avatar = value;
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
