using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderModel
    {
        public int Id { get; set; }
        public System.DateTime DateTime { get; set; }
        public int TotalPrice { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
