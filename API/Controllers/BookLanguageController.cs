using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookLanguageController : ControllerBase
    {
        BookLanguageRepository rep = new BookLanguageRepository();
        [HttpGet]
        public IEnumerable<BookLanguage> Get(int id)
        {
            return rep.GetLanguageByID(id);
        }


        [HttpPost]
        public void add(BookLanguage _book)
        {
            rep.AddLanguage(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveLanguage(id);
        }
        [HttpPut]
        public void Update(BookLanguage book)
        {
            rep.UpdateLanguage(book);
        }

    }
}
