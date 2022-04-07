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
        public IEnumerable<Address> Get(int id)
        {
            return (IEnumerable<Address>)rep.GetAddressByID(id);
        }


        [HttpPost]
        public void add(Address _book)
        {
            rep.AddAddress(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveAddress(id);
        }
        [HttpPut]
        public void Update(Address book)
        {
            rep.UpdateAddress(book);
        }

    }
}
