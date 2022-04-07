using DAL.Models;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class CustOrderRepository
    {
        public IEnumerable<CustOrder> GetAllCustOrders()
        {
            using (var context = new BookStoreContext())
            {
                return context.CustOrder.ToList();
            }
        }
        public IEnumerable<CustOrder> GetCustOrderByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.CustOrder.Where(book => book.OrderId == id).ToList();
            }
        }
        public void AddCustOrder(CustOrder book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new CustOrder();
                _book.OrderDate = book.OrderDate;
                _book.CustomerId = book.CustomerId;
                _book.ShippingMethodId = book.ShippingMethodId;
                _book.DestAddressId = book.DestAddressId;
                context.CustOrder.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveCustOrder(int id)
        {
            using (var context = new BookStoreContext())
            {
                CustOrder book_ = context.CustOrder.Where(book => book.OrderId == id).First();
                context.CustOrder.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateCustOrder(CustOrder book)
        {
            using (var context = new BookStoreContext())
            {
                CustOrder _book = context.CustOrder.Where(bk => bk.OrderId == book.OrderId).First();
                _book.OrderDate = book.OrderDate;
                _book.CustomerId = book.CustomerId;
                _book.ShippingMethodId = book.ShippingMethodId;
                _book.DestAddressId = book.DestAddressId;
                context.SaveChanges();
            }
        }
    }
}
