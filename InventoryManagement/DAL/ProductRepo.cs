using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ProductRepo
    {
        static InventoryManagementEntities context;
        static ProductRepo()
        {
            context = new InventoryManagementEntities();
        }
        public static void AddProduct(Product model)
        {
            context.Products.Add(model);
            context.SaveChanges();
        }
        public static List<Product> GetAllProducts()
        {
            var data = context.Products.ToList();
            return data;
        }
        public static Product GetProduct(int id)
        {
            var data = context.Products.FirstOrDefault(e => e.Id == id);
            return data;
        }

        public static List<string> GetProductNames()
        {
            var data = context.Products.Select(e => e.Name).ToList();
            return data;
        }
    }
}
