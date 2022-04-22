using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class BookDto  : AbstractCusomModelNotifyBase
    {

        private int _bookId;
        public int BookId
        {
            get
            {
                return _bookId;
            }

            set
            {
                if (Equals(_bookId, value))
                {
                    return;
                }

                _bookId = value;
                OnPropertyChanged();
            }
        }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                if (Equals(_title, value))
                {
                    return;
                }

                _title = value;
                OnPropertyChanged();
            }
        }

        private string _isbn13;
        public string Isbn13
        {
            get
            {
                return _isbn13;
            }

            set
            {
                if (Equals(_isbn13, value))
                {
                    return;
                }

                _isbn13 = value;
                OnPropertyChanged();
            }
        }

        private int? _languageId;
        public int? LanguageId
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


        private int? _numPages;
        public int? NumPages
        {
            get
            {
                return _numPages;
            }

            set
            {
                if (Equals(_numPages, value))
                {
                    return;
                }

                _numPages = value;
                OnPropertyChanged();
            }
        }


        private DateTime? _publicationDate;
        public DateTime? PublicationDate
        {
            get
            {
                return _publicationDate;
            }

            set
            {
                if (Equals(_publicationDate, value))
                {
                    return;
                }

                _publicationDate = value;
                OnPropertyChanged();
            }
        }

        private string _publisherName;
        public string PublisherName
        {
            get
            {
                return _publisherName;
            }

            set
            {
                if (Equals(_publisherName, value))
                {
                    return;
                }

                _publisherName = value;
                OnPropertyChanged();
            }
        }

        private int? _publisherId;
        public int? PublisherId
        {
            get
            {
                return _publisherId;
            }

            set
            {
                if (Equals(_publisherId, value))
                {
                    return;
                }

                _publisherId = value;
                OnPropertyChanged();
            }
        }

        private List<AuthorDto> _authors;
        public List<AuthorDto> Authors
        {
            get
            {
                return _authors;
            }

            set
            {
                if (Equals(_authors, value))
                {
                    return;
                }

                _authors = value;
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

        //public Book()
        //{
        //    BookAuthor = new HashSet<BookAuthor>();
        //    OrderLine = new HashSet<OrderLine>();
        //}

        //public int BookId { get; set; }
        //public string Title { get; set; }
        //public string Isbn13 { get; set; }
        //public int? LanguageId { get; set; }
        //public int? NumPages { get; set; }
        //public DateTime? PublicationDate { get; set; }
        //public int? PublisherId { get; set; }

        //public virtual BookLanguage Language { get; set; }
        //public virtual Publisher Publisher { get; set; }
        //public virtual ICollection<BookAuthor> BookAuthor { get; set; }
        //public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}
