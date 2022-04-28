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

        private BookDto _selectedBook;

        public BookDto SelectedBook
        {
            get { return _selectedBook; }
            set { _selectedBook = value; RaisePropertyChanged(); }
        }


        private ObservableCollection<BookDto> _Books = new ObservableCollection<BookDto>();
        public ObservableCollection<BookDto> books
        {
            get { return _Books; }
            set { _Books = value; RaisePropertyChanged(); }
        }
        public BookViewModel()
        {
            GetBooks();
        }

        public async void GetBooks()
        {
            var responce = await client.GetStringAsync("https://localhost:44367/Book");
            books = JsonConvert.DeserializeObject<ObservableCollection<BookDto>>(responce);

            //foreach(var item in book)
            //{
            //    book_.Add(item);
            //    //if (book_.Count>10)
            //    //{
            //    //    break;
            //    //}
            //}
        }
    }
}