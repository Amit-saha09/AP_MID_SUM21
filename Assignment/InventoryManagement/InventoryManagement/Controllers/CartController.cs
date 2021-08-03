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
    [EnableCorsAttribute("*", "*", "*")]
    public class CartController : ApiController
    {
        [Route("api/Cart/GetAll")]
        [HttpGet]
        public List<CartModel> GetCarts()
        {
            return CartService.GetCarts();
        }
       
        [Route("api/Cart/Add")]
        [HttpPost]
        public void AddToCart(ProductModel d)
        {
            CartService.AddToCart(d);
        }
        
    }
}
