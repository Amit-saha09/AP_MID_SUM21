using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class CategoryRepo
    {

        static Inventory2Entities context;
        static CategoryRepo()
        {
            context = new Inventory2Entities();
        }
        public static List<string> GetCategoryNames()
        {
            var data = context.Categories.Select(e => e.Name).ToList();
            return data;
        }
        public static List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }
        public static void AddCategory(Category d)
        {
            context.Categories.Add(d);
            context.SaveChanges();
        }

        public static Category GetCategoryDetail(int id)
        {
            return context.Categories.FirstOrDefault(e => e.Id == id);
        }
    }
}
