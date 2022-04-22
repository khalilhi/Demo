using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class BookLanguageDto : AbstractCusomModelNotifyBase
    {

        private int _languageId;
        public int LanguageId
        {
            get
            {
                return _languageId;
            }

            set
            {
                if (Equals(_languageId, value))
                {
                    return;
                }

                _languageId = value;
                OnPropertyChanged();
            }
        }

         private string _languageCode;
        public string LanguageCode
        {
            get
            {
                return _languageCode;
            }

            set
            {
                if (Equals(_languageCode, value))
                {
                    return;
                }

                _languageCode = value;
                OnPropertyChanged();
            }
        }



        private string _languageName;
        public string LanguageName
        {
            get
            {
                return _languageName;
            }

            set
            {
                if (Equals(_languageName, value))
                {
                    return;
                }

                _languageName = value;
                OnPropertyChanged();
            }
        }

        //public virtual ICollection<BookDto> Book { get; set; }
    }
}
