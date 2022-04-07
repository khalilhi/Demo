using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressStatusController : ControllerBase
    {
        AddressStatusRepository rep = new AddressStatusRepository();
        [HttpGet]
        public IEnumerable<AddressStatus> Get(int id)
        {
            return rep.GetAddressStatusByID(id);
        }


        [HttpPost]
        public void add(AddressStatus _book)
        {
            rep.AddAddressStatus(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveAddressStatus(id);
        }
        [HttpPut]
        public void Update(AddressStatus book)
        {
            rep.UpdateAddressStatus(book);
        }


    }
}
