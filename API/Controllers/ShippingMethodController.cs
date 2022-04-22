using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShippingMethodController : ControllerBase
    {
        ShippingMethodRepository rep = new ShippingMethodRepository();
        [HttpGet]
        public IEnumerable<ShippingMethod> Get(int id)
        {
            return rep.GetShippingMethodByID(id);
        }


        [HttpPost]
        public void add(ShippingMethod _book)
        {
            rep.AddShippingMethod(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveShippingMethod(id);
        }
        [HttpPut]
        public void Update(ShippingMethod book)
        {
            rep.UpdateShippingMethod(book);
        }
    }
}
