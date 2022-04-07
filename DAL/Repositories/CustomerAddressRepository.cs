using DAL.Models;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class CustomerAddressRepository
    {
        public IEnumerable<CustomerAddress> GetAllCustomerAddresses()
        {
            using (var context = new BookStoreContext())
            {
                return context.CustomerAddress.ToList();
            }
        }
        public IEnumerable<CustomerAddress> GetCustomerAddressByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.CustomerAddress.Where(book => book.CustomerId == id).ToList();
            }
        }
        public void AddCustomerAddress(CustomerAddress book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new CustomerAddress();
                _book.CustomerId = book.CustomerId;
                _book.AddressId = book.AddressId;
                _book.StatusId = book.StatusId;
                context.CustomerAddress.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveCustomerAddress(int id)
        {
            using (var context = new BookStoreContext())
            {
                CustomerAddress book_ = context.CustomerAddress.Where(book => book.CustomerId == id).First();
                context.CustomerAddress.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateCustomerAddress(CustomerAddress book)
        {
            using (var context = new BookStoreContext())
            {
                CustomerAddress _book = context.CustomerAddress.Where(bk => bk.CustomerId == book.CustomerId).First();
                _book.AddressId = book.AddressId;
                _book.StatusId = book.StatusId;
                context.SaveChanges();
            }
        }
    }
}
