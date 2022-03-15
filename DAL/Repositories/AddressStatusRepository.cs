using DAL.DBContext;
using Models;

namespace DAL.Repositories
{
    public class AddressStatusRepository
    {
        public IEnumerable<AddressStatus> GetAllAddressStatuses()
        {
            using (var context = new BookStoreContext())
            {
                return context.AddressStatuses.ToList();
            }
        }
        public IEnumerable<AddressStatus> GetAddressStatusByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.AddressStatuses.Where(book => book.StatusId == id).ToList();
            }
        }
        public void AddAddressStatus(AddressStatus book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new AddressStatus();
                _book.StatusId = book.StatusId;
                _book.AddressStatus = book.AddressStatus;
                context.AddressStatuses.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveAddressStatus(int id)
        {
            using (var context = new BookStoreContext())
            {
                AddressStatus book_ = context.AddressStatuses.Where(book => book.StatusId == id).First();
                context.AddressStatuses.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateAddressStatus(AddressStatus book)
        {
            using (var context = new BookStoreContext())
            {
                AddressStatus _book = context.AddressStatuses.Where(bk => bk.StatusId == book.StatusId).First();
                _book.AddressStatus = book.AddressStatus;
                context.SaveChanges();
            }
        }
    }
}
