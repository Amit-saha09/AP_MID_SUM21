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
    public class OrderDetailController : ApiController
    {
        [Route("api/OrderDetail/GetAll/{invoice}")]
        [HttpGet]
        public List<OrderDetailModel> GetOrderDetails(string invoice)
        {
            return OrderDetailsService.GetOrderDetails(invoice);
        }

    }
}
