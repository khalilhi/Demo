using DAL.DBContext;
using Models;

namespace DAL.Repositories
{
    public class BookRepository
    {
        public IEnumerable<Book> Get()
        {
            using (var context = new BookStoreContext())
            {
                return context.Books.ToList();
            }
        }
        public IEnumerable<Book> GetBook(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Books.Where(book => book.BookId == id).ToList();
            }
        }
    }
}
