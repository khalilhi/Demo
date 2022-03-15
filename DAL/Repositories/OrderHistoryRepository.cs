using DAL.DBContext;
using Models;

namespace DAL.Repositories
{
    public class OrderHistoryRepository
    {
        public IEnumerable<OrderHistory> GetAllOrderHistory()
        {
            using (var context = new BookStoreContext())
            {
                return context.OrderHistories.ToList();
            }
        }
        public IEnumerable<OrderHistory> GetOrderHistoryByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.OrderHistories.Where(book => book.HistoryId == id).ToList();
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
                context.OrderHistories.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveOrderHistory(int id)
        {
            using (var context = new BookStoreContext())
            {
                OrderHistory book_ = context.OrderHistories.Where(book => book.HistoryId == id).First();
                context.OrderHistories.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateOrderHistory(OrderHistory book)
        {
            using (var context = new BookStoreContext())
            {
                OrderHistory _book = context.OrderHistories.Where(bk => bk.HistoryId == book.HistoryId).First();
                _book.OrderId = book.OrderId;
                _book.StatusId = book.StatusId;
                _book.StatusDate = book.StatusDate;
                context.SaveChanges();
            }
        }
    }
}
