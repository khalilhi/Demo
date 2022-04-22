using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        CountryRepository rep = new CountryRepository();
        [HttpGet]
        public IEnumerable<Country> Get(int id)
        {
            return rep.GetCountryByID(id);
        }


        [HttpPost]
        public void add(Country _book)
        {
            rep.AddCountryk(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveCountry(id);
        }
        [HttpPut]
        public void Update(Country book)
        {
            rep.UpdateCountry(book);
        }

    }
}
