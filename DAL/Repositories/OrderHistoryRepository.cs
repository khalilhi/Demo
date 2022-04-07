using DAL.Models;
using Models;
using System.Collections.Generic;
using System.Linq;
namespace DAL.Repositories
{
    public class OrderHistoryRepository
    {
        public IEnumerable<OrderHistory> GetAllOrderHistory()
        {
            using (var context = new BookStoreContext())
            {
                return context.OrderHistory.ToList();
            }
        }
        public IEnumerable<OrderHistory> GetOrderHistoryByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.OrderHistory.Where(book => book.HistoryId == id).ToList();
            }
        }
        public void AddOrderHistory(OrderHistory book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new OrderHistory();
                _book.OrderId = book.OrderId;
                _book.StatusId = book.StatusId;
                _book.StatusDate = book.StatusDate;
                context.OrderHistory.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveOrderHistory(int id)
        {
            using (var context = new BookStoreContext())
            {
                OrderHistory book_ = context.OrderHistory.Where(book => book.HistoryId == id).First();
                context.OrderHistory.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateOrderHistory(OrderHistory book)
        {
            using (var context = new BookStoreContext())
            {
                OrderHistory _book = context.OrderHistory.Where(bk => bk.HistoryId == book.HistoryId).First();
                _book.OrderId = book.OrderId;
                _book.StatusId = book.StatusId;
                _book.StatusDate = book.StatusDate;
                context.SaveChanges();
            }
        }
    }
}
