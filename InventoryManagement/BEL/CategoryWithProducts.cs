﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CategoryWithProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductDetails> ProductDetails { get; set; }
    }
}
