using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace FreeMet2.ViewModel
{
    public class LoginAccountViewModel:ViewModelBase
    {
        public LoginAccountViewModel()
        {
            
        }

        #region Dependency Properties

        private bool _isRemember;

        public bool IsRemember
        {
            get => _isRemember;
            set
            {
                _isRemember = value;
                this.Set(nameof(IsRemember), ref value);
            }
        }

        private string _userName;

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                this.Set(nameof(UserName), ref value);
            }
        }

        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                this.Set(nameof(Password), ref value);
            }
        }

        #endregion

        #region Command

        private RelayCommand _loginCommand;

        public RelayCommand LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                {
                    _loginCommand = new RelayCommand(LoginAccount);
                }

                return _loginCommand;
            }
        }

        #endregion

        #region Methods

        private void LoginAccount()
        {
            
        }

        #endregion
    }
}
