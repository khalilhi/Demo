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
        BookRepository rep = new BookRepository();
        [HttpGet]
        public IEnumerable<Book> Get(int id)
        {
            return rep.GetBookByID(id);
        }

    }

}
