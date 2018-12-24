using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SalesManagement.Server.DataAccess;
using SalesManagement.Shared.Models;

namespace SalesManagement.Server.Controllers

{
    public class CustomersController : Controller
    {
        CustomerDA da = new CustomerDA();

        [HttpGet]
        [Route("api/Customer/Index")]
        public IEnumerable<Customer> Index()
        {
            return da.GetAllCustomers();
        }

        [HttpPost]
        [Route("api/Customer/Create")]
        public void Create([FromBody] Customer customer)
        {
            if (ModelState.IsValid)
                da.AddCustomer(customer);
        }

        [HttpGet]
        [Route("api/Customer/Details/{id}")]
        public Customer Details(int id)
        {

            return da.GetCustomerData(id);
        }

        [HttpPut]
        [Route("api/Customer/Edit")]
        public void Edit([FromBody]Customer customer)
        {
            if (ModelState.IsValid)
                da.UpdateCustomer(customer);
        }

        [HttpDelete]
        [Route("api/Customer/Delete/{id}")]
        public void Delete(int id)
        {
            da.DeleteCustomer(id);
        }
    }
}
