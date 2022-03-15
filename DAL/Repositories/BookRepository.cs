using DAL.DBContext;
using Models;

namespace DAL.Repositories
{
    public class BookRepository
    {
        public IEnumerable<Book> GetAllBooks()
        {
            using (var context = new BookStoreContext())
            {
                return context.Books.ToList();
            }
        }
        public IEnumerable<Book> GetBookByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Books.Where(book => book.BookId == id).ToList();
            }
        }
        public void AddBook(Book book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new Book();
                _book.Title = book.Title;
                _book.Isbn13 = book.Isbn13;
                _book.LanguageId= book.LanguageId;
                _book.NumPages= book.NumPages;
                _book.PublicationDate= book.PublicationDate;
                _book.PublisherId= book.PublisherId;
                context.Books.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveBook(int id)
        {
            using (var context = new BookStoreContext())
            {
                Book book_ = context.Books.Where(book => book.BookId == id).First();
                context.Books.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateBook(Book book)
        {
            using (var context = new BookStoreContext())
            {
                Book _book = context.Books.Where(bk => bk.BookId == book.BookId).First();
                _book.Title = book.Title;
                _book.Isbn13 = book.Isbn13;
                _book.LanguageId = book.LanguageId;
                _book.NumPages = book.NumPages;
                _book.PublicationDate = book.PublicationDate;
                _book.PublisherId = book.PublisherId;
                context.SaveChanges();
            }
        }


    }
}
