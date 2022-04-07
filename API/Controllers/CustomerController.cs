using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        CustomerRepository rep = new CustomerRepository();
        [HttpGet]
        public IEnumerable<Customer> Get(int id)
        {
            return rep.GetCustomerByID(id);
        }


        [HttpPost]
        public void add(Customer _book)
        {
            rep.AddCustomer(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveCustomer(id);
        }
        [HttpPut]
        public void Update(Customer book)
        {
            rep.UpdateCustomer(book);
        }
    }
}
