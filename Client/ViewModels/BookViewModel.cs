using GalaSoft.MvvmLight;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModels
{
    class BookViewModel : ViewModelBase
    {
        private HttpClient client = new HttpClient();
        private ObservableCollection<Book> _Book = new ObservableCollection<Book>();
        public ObservableCollection<Book> book_
        {
            get { return _Book; }
            set { _Book = value; RaisePropertyChanged(); }
        }
        public BookViewModel()
        {
            GetBooks();
        }

        public async void GetBooks()
        {
            var responce = await client.GetStringAsync("https://localhost:44367/Book");
            var book = JsonConvert.DeserializeObject<ObservableCollection<Book>>(responce);

            foreach(var item in book)
            {
                book_.Add(item);
                if (book_.Count>10)
                {
                    break;
                }
            }
        }
    }
}