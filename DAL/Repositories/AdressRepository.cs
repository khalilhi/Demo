using DAL.DBContext;
using Models;

namespace DAL.Repositories
{
    public class AdressRepository
    {
        public IEnumerable<Address> GetAllAddresses()
        {
            using (var context = new BookStoreContext())
            {
                return context.Addresses.ToList();
            }
        }
        public IEnumerable<Address> GetAddressByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Addresses.Where(book => book.AddressId == id).ToList();
            }
        }
        public void AddAddress(Address book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new Address();
                _book.StreetNumber = book.StreetNumber;
                _book.StreetName = book.StreetName;
                _book.City = book.City;
                _book.CountryId = book.CountryId;
                context.Addresses.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveAddress(int id)
        {
            using (var context = new BookStoreContext())
            {
                Address book_ = context.Addresses.Where(book => book.AddressId == id).First();
                context.Addresses.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateAddress(Address book)
        {
            using (var context = new BookStoreContext())
            {
                Address _book = context.Addresses.Where(bk => bk.AddressId == book.AddressId).First();
                _book.StreetNumber = book.StreetNumber;
                _book.StreetName = book.StreetName;
                _book.City = book.City;
                _book.CountryId = book.CountryId;
                context.SaveChanges();
            }
        }
    }
}
