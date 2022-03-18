using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustOrderController : ControllerBase
    {
        CustOrderRepository rep = new CustOrderRepository();
        [HttpGet]
        public IEnumerable<CustOrder> Get(int id)
        {
            return rep.GetCustOrderByID(id);
        }


        [HttpPost]
        public void add(CustOrder _book)
        {
            rep.AddCustOrder(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveCustOrder(id);
        }
        [HttpPut]
        public void Update(CustOrder book)
        {
            rep.UpdateCustOrder(book);
        }
    }
}
