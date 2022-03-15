using DAL.DBContext;
using Models;

namespace DAL.Repositories
{
    public class PublisherRepository
    {
        public IEnumerable<Publisher> GetAllPublishers()
        {
            using (var context = new BookStoreContext())
            {
                return context.Publishers.ToList();
            }
        }
        public IEnumerable<Publisher> GetPublisherByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Publishers.Where(book => book.PublisherId == id).ToList();
            }
        }
        public void AddPublisher(Publisher book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new Publisher();
                _book.PublisherName = book.PublisherName;
                _book.UtilisateurId = book.UtilisateurId;
                context.Publishers.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemovePublisher(int id)
        {
            using (var context = new BookStoreContext())
            {
                Publisher book_ = context.Publishers.Where(book => book.PublisherId == id).First();
                context.Publishers.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdatePublisher(Publisher book)
        {
            using (var context = new BookStoreContext())
            {
                Publisher _book = context.Publishers.Where(bk => bk.PublisherId == book.PublisherId).First();
                _book.PublisherName = book.PublisherName;
                _book.UtilisateurId = book.UtilisateurId;
                context.SaveChanges();
            }
        }
    }
}
