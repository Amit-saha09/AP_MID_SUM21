﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CategoryDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductModel> Products { get; set; }
    }
}
