using DAL.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace DAL.Repository
{
    public class BookRepository
    {
        public IEnumerable<Book> Get()
        {
            using(var context = new DemoDBContext())
            {
                return context.Books.ToList();
            }
        }

    }
}
