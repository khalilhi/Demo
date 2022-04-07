using DAL.Models;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class ShippingMethodRepository
    {
        public IEnumerable<ShippingMethod> GetAllShippingMethods()
        {
            using (var context = new BookStoreContext())
            {
                return context.ShippingMethod.ToList();
            }
        }
        public IEnumerable<ShippingMethod> GetShippingMethodByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.ShippingMethod.Where(book => book.MethodId == id).ToList();
            }
        }
        public void AddShippingMethod(ShippingMethod book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new ShippingMethod();
                _book.MethodName = book.MethodName;
                _book.Cost = book.Cost;
                context.ShippingMethod.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveShippingMethod(int id)
        {
            using (var context = new BookStoreContext())
            {
                ShippingMethod book_ = context.ShippingMethod.Where(book => book.MethodId == id).First();
                context.ShippingMethod.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateShippingMethod(ShippingMethod book)
        {
            using (var context = new BookStoreContext())
            {
                ShippingMethod _book = context.ShippingMethod.Where(bk => bk.MethodId == book.MethodId).First();
                _book.MethodName = book.MethodName;
                _book.Cost = book.Cost;
                context.SaveChanges();
            }
        }
    }
}
