using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
       

        public int CategoryId { get; set; }
    }
}
