using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderStatusController : ControllerBase
    {
        OrderStatusRepository rep = new OrderStatusRepository();
        [HttpGet]
        public IEnumerable<OrderStatus> Get(int id)
        {
            return rep.GetOrderStatusByID(id);
        }


        [HttpPost]
        public void add(OrderStatus _book)
        {
            rep.AddOrderStatus(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveOrderStatus(id);
        }
        [HttpPut]
        public void Update(OrderStatus book)
        {
            rep.UpdateOrderStatus(book);
        }
    }
}
