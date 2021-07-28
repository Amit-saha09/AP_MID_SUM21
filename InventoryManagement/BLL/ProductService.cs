using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ProductService
    {
        public static void AddProduct(ProductDetails model)
        {
            var data = AutoMapper.Mapper.Map<ProductDetails, Product>(model);
            ProductRepo.AddProduct(data);
        }
        public static ProductDetails GetProduct(int id)
        {
            var data = ProductRepo.GetProduct(id);
            var st = AutoMapper.Mapper.Map<Product, ProductDetails>(data);
            return st;
        }
        public static List<ProductDetails> GetAllProducts()
        {
            var data = ProductRepo.GetAllProducts();
            var st = AutoMapper.Mapper.Map<List<Product>, List<ProductDetails>>(data);
            return st;
        }

        public static List<string> GetProductNames()
        {
            var data = ProductRepo.GetProductNames();
            return data;
        }
    }
}
