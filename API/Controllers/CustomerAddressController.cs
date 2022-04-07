using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerAddressController : ControllerBase
    {
        CustomerAddressRepository rep = new CustomerAddressRepository();
        [HttpGet]
        public IEnumerable<CustomerAddress> Get(int id)
        {
            return rep.GetCustomerAddressByID(id);
        }


        [HttpPost]
        public void add(CustomerAddress _book)
        {
            rep.AddCustomerAddress(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveCustomerAddress(id);
        }
        [HttpPut]
        public void Update(CustomerAddress book)
        {
            rep.UpdateCustomerAddress(book);
        }
    }
}
