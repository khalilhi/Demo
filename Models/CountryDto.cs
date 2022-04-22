using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class CountryDto : AbstractCusomModelNotifyBase
    {
        private int _countryId;
        public int CountryId
        {
            get
            {
                return _countryId;
            }

            set
            {
                if (Equals(_countryId, value))
                {
                    return;
                }

                _countryId = value;
                OnPropertyChanged();
            }
        }

         private string _countryName;
        public string CountryName
        {
            get
            {
                return _countryName;
            }

            set
            {
                if (Equals(_countryName, value))
                {
                    return;
                }

                _countryName = value;
                OnPropertyChanged();
            }
        }
    }
}
