using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
namespace InventoryManagement.Controllers
{
   [ EnableCorsAttribute("*","*","*")]
    public class ProductController : ApiController
    {
        [Route("api/Product/GetAll")]
        [HttpGet]
        public List<ProductModel> GetAllProducts()
        {
            return ProductService.GetAllProducts();
        }
        [Route("api/Product/{id}")]
        [HttpGet]
        public ProductModel GetProduct(int id)
        {
            return ProductService.GetProduct(id);
        }
        [Route("api/Product/Add")]
        [HttpPost]
        public void AddProduct(ProductModel model)
        {
            ProductService.AddProduct(model);
        }
        [Route("api/Product/Names")]
        [HttpGet]
        public List<string> GetProductNames()
        {
            return ProductService.GetProductNames();
        }

    }
}
