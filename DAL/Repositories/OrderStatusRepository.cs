using DAL.DBContext;
using Models;

namespace DAL.Repositories
{
    public class OrderStatusRepository
    {
        public IEnumerable<OrderStatus> GetAllOrderStatuses()
        {
            using (var context = new BookStoreContext())
            {
                return context.OrderStatuses.ToList();
            }
        }
        public IEnumerable<OrderStatus> GetOrderStatusByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.OrderStatuses.Where(book => book.StatusId == id).ToList();
            }
        }
        public void AddOrderStatus(OrderStatus book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new OrderStatus();
                _book.StatusValue = book.StatusValue;
                context.OrderStatuses.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveOrderStatus(int id)
        {
            using (var context = new BookStoreContext())
            {
                OrderStatus book_ = context.OrderStatuses.Where(book => book.StatusId == id).First();
                context.OrderStatuses.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateOrderStatus(OrderStatus book)
        {
            using (var context = new BookStoreContext())
            {
                OrderStatus _book = context.OrderStatuses.Where(bk => bk.StatusId == book.StatusId).First();
                _book.StatusValue = book.StatusValue;
                context.SaveChanges();
            }
        }
    }
}
