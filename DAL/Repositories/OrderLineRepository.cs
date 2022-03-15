using DAL.DBContext;
using Models;

namespace DAL.Repositories
{
    public class OrderLineRepository
    {
        public IEnumerable<OrderLine> GetAllOrderLines()
        {
            using (var context = new BookStoreContext())
            {
                return context.OrderLines.ToList();
            }
        }
        public IEnumerable<OrderLine> GetOrderLineByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.OrderLines.Where(book => book.LineId == id).ToList();
            }
        }
        public void AddOrderLine(OrderLine book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new OrderLine();
                _book.OrderId = book.OrderId;
                _book.BookId = book.BookId;
                _book.Price = book.Price;
                context.OrderLines.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveOrderLine(int id)
        {
            using (var context = new BookStoreContext())
            {
                OrderLine book_ = context.OrderLines.Where(book => book.LineId == id).First();
                context.OrderLines.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateOrderLine(OrderLine book)
        {
            using (var context = new BookStoreContext())
            {
                OrderLine _book = context.OrderLines.Where(bk => bk.LineId == book.LineId).First();
                _book.OrderId = book.OrderId;
                _book.BookId = book.BookId;
                _book.Price = book.Price;
                context.SaveChanges();
            }
        }
    }
}
