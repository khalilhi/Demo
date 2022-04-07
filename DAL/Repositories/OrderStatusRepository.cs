using DAL.Models;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class OrderStatusRepository
    {
        public IEnumerable<OrderStatus> GetAllOrderStatuses()
        {
            using (var context = new BookStoreContext())
            {
                return context.OrderStatus.ToList();
            }
        }
        public IEnumerable<OrderStatus> GetOrderStatusByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.OrderStatus.Where(book => book.StatusId == id).ToList();
            }
        }
        public void AddOrderStatus(OrderStatus book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new OrderStatus();
                _book.StatusValue = book.StatusValue;
                context.OrderStatus.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveOrderStatus(int id)
        {
            using (var context = new BookStoreContext())
            {
                OrderStatus book_ = context.OrderStatus.Where(book => book.StatusId == id).First();
                context.OrderStatus.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateOrderStatus(OrderStatus book)
        {
            using (var context = new BookStoreContext())
            {
                OrderStatus _book = context.OrderStatus.Where(bk => bk.StatusId == book.StatusId).First();
                _book.StatusValue = book.StatusValue;
                context.SaveChanges();
            }
        }
    }
}
