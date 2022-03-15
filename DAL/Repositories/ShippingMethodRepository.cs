using DAL.DBContext;
using Models;

namespace DAL.Repositories
{
    public class ShippingMethodRepository
    {
        public IEnumerable<ShippingMethod> GetAllShippingMethods()
        {
            using (var context = new BookStoreContext())
            {
                return context.ShippingMethods.ToList();
            }
        }
        public IEnumerable<ShippingMethod> GetShippingMethodByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.ShippingMethods.Where(book => book.MethodId == id).ToList();
            }
        }
        public void AddShippingMethod(ShippingMethod book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new ShippingMethod();
                _book.MethodName = book.MethodName;
                _book.Cost = book.Cost;
                context.ShippingMethods.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveShippingMethod(int id)
        {
            using (var context = new BookStoreContext())
            {
                ShippingMethod book_ = context.ShippingMethods.Where(book => book.MethodId == id).First();
                context.ShippingMethods.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateShippingMethod(ShippingMethod book)
        {
            using (var context = new BookStoreContext())
            {
                ShippingMethod _book = context.ShippingMethods.Where(bk => bk.MethodId == book.MethodId).First();
                _book.MethodName = book.MethodName;
                _book.Cost = book.Cost;
                context.SaveChanges();
            }
        }
    }
}
