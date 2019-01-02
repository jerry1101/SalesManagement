using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SalesManagement.Server.DataAccess;
using SalesManagement.Shared.ValueObject;

namespace SalesManagement.Server.Controllers

{
    [Authorize(Roles = "Administrator")]
    public class CustomersController : Controller
    {
        CustomerDA da = new CustomerDA();

        public CustomersController()
        {
           
        }

        [HttpGet]
        [Route("api/Customer/Index")]
        [Produces(("application/json"))]
        
        public IEnumerable<CustomerVO> Index()
        {
            List<CustomerVO> customerList = new List<CustomerVO>();
            foreach (var c in da.GetAllCustomers())
            {
                customerList.Add(Mapper.Map<CustomerVO>(c));
            }
            
            return customerList;
        }

        [HttpPost]
        [Route("api/Customer/Create")]
        public void Create([FromBody] CustomerVO customer)
        {
            if (ModelState.IsValid)
                da.AddCustomer(Mapper.Map<Models.Customer>(customer));
        }

        [HttpGet]
        [Route("api/Customer/Details/{id}")]
        public CustomerVO Details(int id)
        {

            return Mapper.Map<CustomerVO>(da.GetCustomerData(id));
        }

        [HttpPut]
        [Route("api/Customer/Edit")]
        public void Edit([FromBody]CustomerVO vo)
        {
            if (ModelState.IsValid)
                da.UpdateCustomer(Mapper.Map<Models.Customer>(vo));
        }

        [HttpDelete]
        [Route("api/Customer/Delete/{id}")]
        public void Delete(int id)
        {
            da.DeleteCustomer(id);
        }
    }
}
