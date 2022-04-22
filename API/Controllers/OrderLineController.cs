using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderLineController : ControllerBase
    {
        OrderLineRepository rep = new OrderLineRepository();
        [HttpGet]
        public IEnumerable<OrderLine> Get(int id)
        {
            return rep.GetOrderLineByID(id);
        }


        [HttpPost]
        public void add(OrderLine _book)
        {
            rep.AddOrderLine(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveOrderLine(id);
        }
        [HttpPut]
        public void Update(OrderLine book)
        {
            rep.UpdateOrderLine(book);
        }
    }
}
