using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        BookRepository rep = new BookRepository();
        [HttpGet]
        public IEnumerable<Book> Get(int id)
        {
            return rep.GetBookByID(id);
        }


        [HttpPost]
        public void add(Book _book)
        {
            rep.AddBook(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveBook(id);
        }
        [HttpPut]
        public void Update(Book book)
        {
            rep.UpdateBook(book);
        }

    }

}
