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
        public static void AddProduct(ProductModel model)
        {
            var data = AutoMapper.Mapper.Map<ProductModel, Product>(model);
            ProductRepo.AddProduct(data);
        }
        public static ProductModel GetProduct(int id)
        {
            var data = ProductRepo.GetProduct(id);
            var st = AutoMapper.Mapper.Map<Product, ProductModel>(data);
            return st;
        }
        public static List<ProductModel> GetAllProducts()
        {
            var data = ProductRepo.GetAllProducts();
            var st = AutoMapper.Mapper.Map<List<Product>, List<ProductModel>>(data);
            return st;
        }

        public static List<string> GetProductNames()
        {
            var data = ProductRepo.GetProductNames();
            return data;
        }
    }
}
