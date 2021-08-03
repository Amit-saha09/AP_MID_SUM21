using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderDetailModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public string InvoiceNumber { get; set; }
        public int TotalPrice { get; set; }

        public int ProductId  { get; set; }
    }
}
