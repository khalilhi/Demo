using Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LoginModel
{
    public class RequestUserAuth : AbstractCusomModelNotifyBase
    {
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                if (Equals(_firstName, value))
                {
                    return;
                }

                _firstName = value;
                OnPropertyChanged();
            }
        }

         private string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                if (Equals(_password, value))
                {
                    return;
                }

                _password = value;
                OnPropertyChanged();
            }
        }

    }
}
