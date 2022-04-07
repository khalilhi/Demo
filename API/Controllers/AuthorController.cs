using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        AuthorRepository rep = new AuthorRepository();
        [HttpGet]
        public IEnumerable<Author> Get(int id)
        {
            return rep.GetAuthorByID(id);
        }


        [HttpPost]
        public void add(Author _book)
        {
            rep.AddAuthor(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveAuthor(id);
        }
        [HttpPut]
        public void Update(Author book)
        {
            rep.UpdateAuthor(book);
        }

    }
}
