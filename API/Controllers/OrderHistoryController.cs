using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderHistoryController : ControllerBase
    {
        OrderHistoryRepository rep = new OrderHistoryRepository();
        [HttpGet]
        public IEnumerable<OrderHistory> Get(int id)
        {
            return rep.GetOrderHistoryByID(id);
        }


        [HttpPost]
        public void add(OrderHistory _book)
        {
            rep.AddOrderHistory(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveOrderHistory(id);
        }
        [HttpPut]
        public void Update(OrderHistory book)
        {
            rep.UpdateOrderHistory(book);
        }
    }
}
