using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class UtilisateurDto  : AbstractCusomModelNotifyBase
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                if (Equals(_id, value))
                {
                    return;
                }

                _id = value;
                OnPropertyChanged();
            }
        }

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

         private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                if (Equals(_lastName, value))
                {
                    return;
                }

                _lastName = value;
                OnPropertyChanged();
            }
        }

         private string _tel;
        public string Tel
        {
            get
            {
                return _tel;
            }

            set
            {
                if (Equals(_tel, value))
                {
                    return;
                }

                _tel = value;
                OnPropertyChanged();
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                if (Equals(_email, value))
                {
                    return;
                }

                _email = value;
                OnPropertyChanged();
            }
        }

        private string _motPasse;
        public string MotPasse
        {
            get
            {
                return _motPasse;
            }

            set
            {
                if (Equals(_motPasse, value))
                {
                    return;
                }

                _motPasse = value;
                OnPropertyChanged();
            }
        }

        private bool _isRealPerson;
        public bool IsRealPerson
        {
            get
            {
                return _isRealPerson;
            }

            set
            {
                if (Equals(_isRealPerson, value))
                {
                    return;
                }

                _isRealPerson = value;
                OnPropertyChanged();
            }
        }

        private bool _isHidden;
        public bool IsHidden
        {
            get
            {
                return _isHidden;
            }

            set
            {
                if (Equals(_isHidden, value))
                {
                    return;
                }

                _isHidden = value;
                OnPropertyChanged();
            }
        }

        private bool _canBeDeleted;
        public bool CanBeDeleted
        {
            get
            {
                return _canBeDeleted;
            }

            set
            {
                if (Equals(_canBeDeleted, value))
                {
                    return;
                }

                _canBeDeleted = value;
                OnPropertyChanged();
            }
        }

        private bool _annuler;
        public bool Annuler
        {
            get
            {
                return _annuler;
            }

            set
            {
                if (Equals(_annuler, value))
                {
                    return;
                }

                _annuler = value;
                OnPropertyChanged();
            }
        }
    }
}
