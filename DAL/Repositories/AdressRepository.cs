using DAL.Models;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class AdressRepository
    {
        public IEnumerable<Address> GetAllAddresses()
        {
            using (var context = new BookStoreContext())
            {
                return (IEnumerable<Address>)context.Address.ToList();
            }
        }
        public IEnumerable<Address> GetAddressByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Address.Where(book => book.AddressId == id).ToList();
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
                context.Address.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveAddress(int id)
        {
            using (var context = new BookStoreContext())
            {
                Address book_ = context.Address.Where(book => book.AddressId == id).First();
                context.Address.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateAddress(Address book)
        {
            using (var context = new BookStoreContext())
            {
                Address _book = context.Address.Where(bk => bk.AddressId == book.AddressId).First();
                _book.StreetNumber = book.StreetNumber;
                _book.StreetName = book.StreetName;
                _book.City = book.City;
                _book.CountryId = book.CountryId;
                context.SaveChanges();
            }
        }
    }
}
