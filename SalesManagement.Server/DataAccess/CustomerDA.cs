
using SalesManagement.Shared.Models;  
using Microsoft.EntityFrameworkCore;  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace SalesManagement.Server.DataAccess
{
    public class CustomerDA
    {
        SalesDbContext db = new SalesDbContext();

        //To Get all employees details   
        public IEnumerable<Customer> GetAllCustomers()
        {
            try
            {
                return db.tblCustomer.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new employee record     
        public void AddCustomer(Customer customer)
        {
            try
            {
                db.tblCustomer.Add(customer);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee    
        public void UpdateCustomer(Customer customer)
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
        public Customer GetCustomerData(int id)
        {
            try
            {
                Customer employee = db.tblCustomer.Find(id);
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
                Customer emp = db.tblCustomer.Find(id);
                db.tblCustomer.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}