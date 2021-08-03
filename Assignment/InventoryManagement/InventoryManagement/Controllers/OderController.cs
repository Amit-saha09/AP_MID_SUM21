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
    public class OderController : ApiController
    {
        [Route("api/Order/GetAll")]
        [HttpGet]
        public List<OrderModel> GetOrders()
        {
            return OrderService.GetOders();
        }

        [Route("api/Order/Add")]
        [HttpPost]
        public void CreateOrder()
        {
           OrderService.CreateOrder();
        }

        [Route("api/Order/Get/{invoice}")]
        [HttpGet]
        public OrderModel GetOrder(string invoice)
        {
            return OrderService.GetOrder(invoice);
        }
    }
}
