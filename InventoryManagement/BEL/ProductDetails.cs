﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class ProductDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
        public System.DateTime Created_at { get; set; }
        public System.DateTime Updated_at { get; set; }
        public System.DateTime Deleted_at { get; set; }
        public string Created_by { get; set; }
        public string Updated_by { get; set; }
        public string Deleted_by { get; set; }

       
    }
}
