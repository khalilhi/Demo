using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        BookRepository rep = new BookRepository();
        [HttpGet]
        //public IEnumerable<Book> Get(int id)
        //{
        //    return rep.GetBookByID(id);
        //}
        public IEnumerable<BookDto> GetAll()
        {
            return rep.GetAllBooks();
        }
        


        [HttpPost]
        public void add(BookDto _book)
        {
            rep.AddBook(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveBook(id);
        }
        [HttpPut]
        public void Update(BookDto book)
        {
            rep.UpdateBook(book);
        }

    }

}
