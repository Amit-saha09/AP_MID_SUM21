using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class CategoryRepo
    {

        static InventoryManagementEntities context;
        static CategoryRepo()
        {
            context = new InventoryManagementEntities();
        }
        public static List<string> GetCategoryNames()
        {
            var data = context.Categorys.Select(e => e.Name).ToList();
            return data;
        }
        public static List<Category> GetCategorys()
        {
            return context.Categorys.ToList();
        }
        public static void AddCategory(Category d)
        {
            context.Categorys.Add(d);
            context.SaveChanges();
        }

        public static Category GetCategoryDetail(int id)
        {
            return context.Categorys.FirstOrDefault(e => e.Id == id);
        }
    }
}
