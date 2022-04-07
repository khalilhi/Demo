using DAL.Models;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class AddressStatusRepository
    {
        public IEnumerable<AddressStatus> GetAllAddressStatuses()
        {
            using (var context = new BookStoreContext())
            {
                return (IEnumerable<AddressStatus>)context.AddressStatus.ToList();
            }
        }
        public IEnumerable<AddressStatus> GetAddressStatusByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.AddressStatus.Where(book => book.StatusId == id).ToList();
            }
        }
        public void AddAddressStatus(AddressStatus book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new AddressStatus();
                _book.StatusId = book.StatusId;
                _book.AddressStatus1 = book.AddressStatus1;
                context.AddressStatus.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveAddressStatus(int id)
        {
            using (var context = new BookStoreContext())
            {
                AddressStatus book_ = context.AddressStatus.Where(book => book.StatusId == id).First();
                context.AddressStatus.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateAddressStatus(AddressStatus book)
        {
            using (var context = new BookStoreContext())
            {
                AddressStatus _book = context.AddressStatus.Where(bk => bk.StatusId == book.StatusId).First();
                _book.AddressStatus1 = book.AddressStatus1;
                context.SaveChanges();
            }
        }
    }
}
