using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GlobalController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Book> Get(int id)
        {
            var rep = new BookRepository();
            return rep.GetBook(id);
        }
    }
}
