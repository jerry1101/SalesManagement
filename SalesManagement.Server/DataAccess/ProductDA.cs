
using SalesManagement.Shared.Models;  
using Microsoft.EntityFrameworkCore;  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;
using SalesManagement.Server.Models;

namespace SalesManagement.Server.DataAccess
{
    public class ProductDA
    {
        SalesManagementContext db = new SalesManagementContext();

        //To Get all Product details   
        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                return db.Product.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new Product record     
        public void AddProduct(Product product)
        {
            try
            {
                db.Product.Add(product);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particular Product    
        public void UpdateProduct(Models.Product product)
        {
            try
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Product    
        public Product GetProductData(int id)
        {
            try
            {
                return db.Product.Find(id);
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Product    
        public void DeleteProduct(int id)
        {
            try
            {
                Product product = db.Product.Find(id);
                db.Product.Remove(product);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}