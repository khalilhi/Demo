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

    }
}
