using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublisherController : ControllerBase
    {
        PublisherRepository rep = new PublisherRepository();
        [HttpGet]
        public IEnumerable<Publisher> Get(int id)
        {
            return rep.GetPublisherByID(id);
        }


        [HttpPost]
        public void add(Publisher _book)
        {
            rep.AddPublisher(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemovePublisher(id);
        }
        [HttpPut]
        public void Update(Publisher book)
        {
            rep.UpdatePublisher(book);
        }
    }
}
