
using SalesManagement.Shared.Models;  
using Microsoft.EntityFrameworkCore;  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;
using SalesManagement.Server.Models;

namespace SalesManagement.Server.DataAccess
{
    public class CustomerDA
    {
        SalesManagementContext db = new SalesManagementContext();

        //To Get all employees details   
        public IEnumerable<Models.Customer> GetAllCustomers()
        {
            try
            {
                return db.Customer.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new employee record     
        public void AddCustomer(Models.Customer customer)
        {
            try
            {
                db.Customer.Add(customer);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee    
        public void UpdateCustomer(Models.Customer customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee    
        public Models.Customer GetCustomerData(int id)
        {
            try
            {
                Models.Customer employee = db.Customer.Find(id);
                return employee;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular employee    
        public void DeleteCustomer(int id)
        {
            try
            {
                Models.Customer emp = db.Customer.Find(id);
                db.Customer.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}