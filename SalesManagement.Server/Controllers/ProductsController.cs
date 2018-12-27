using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesManagement.Server.DataAccess;
using SalesManagement.Shared.ValueObject;
using System.Collections.Generic;
using System.Linq;

namespace SalesManagement.Server.Controllers

{
    public class ProductsController : Controller
    {
        ProductDA da = new ProductDA();

        public ProductsController()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Models.Product, ProductVO>());
        }

        [HttpGet]
        [Route("api/Product/Index")]
        [Produces(("application/json"))]
        public IEnumerable<ProductVO> Index()
        {
            List<ProductVO> productList = new List<ProductVO>();
            foreach (var c in da.GetAllProducts())
            {
                productList.Add(Mapper.Map<ProductVO>(c));
            }

            return productList;
        }

        [HttpGet]
        [Route("api/Product/FirstTen")]
        [Produces(("application/json"))]
        public IEnumerable<ProductVO> FirstTen()
        {
            
            var productList = new List<ProductVO>() ;
            
            foreach (var p in da.GetAllProducts().Take(10))
            {
                productList.Add(Mapper.Map<ProductVO>(p));
            }

            return productList;
        }

        [HttpPost]
        [Route("api/Product/Create")]
        public void Create([FromBody] ProductVO Product)
        {
            if (ModelState.IsValid)
                da.AddProduct(Mapper.Map<Models.Product>(Product));
        }

        [HttpGet]
        [Route("api/Product/Details/{id}")]
        public ProductVO Details(int id)
        {

            return Mapper.Map<ProductVO>(da.GetProductData(id));
        }

        [HttpPut]
        [Route("api/Product/Edit")]
        public void Edit([FromBody]ProductVO vo)
        {
            if (ModelState.IsValid)
                da.UpdateProduct(Mapper.Map<Models.Product>(vo));
        }

        [HttpDelete]
        [Route("api/Product/Delete/{id}")]
        public void Delete(int id)
        {
            da.DeleteProduct(id);
        }
    }
}
