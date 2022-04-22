using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using System.Collections.Generic;
using Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        AdressRepository rep = new AdressRepository();
        [HttpGet]
        public IEnumerable<DAL.Models.Address> Get(int id)
        {
            return (IEnumerable<DAL.Models.Address>)rep.GetAddressByID(id);
        }


        [HttpPost]
        public void add(DAL.Models.Address _book)
        {
            rep.AddAddress(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveAddress(id);
        }
        [HttpPut]
        public void Update(DAL.Models.Address book)
        {
            rep.UpdateAddress(book);
        }

    }
}
