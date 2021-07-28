using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryService
    {
        public static List<string> GetCategoryNames()
        {
            return CategoryRepo.GetCategoryNames();
        }
        public static List<CategoryDetails> GetCategorys()
        {
            var Categorys = CategoryRepo.GetCategorys();
            var data = AutoMapper.Mapper.Map<List<Category>, List<CategoryDetails>>(Categorys);
            /* List<CategoryModel> data = new List<CategoryModel>();
             foreach (var d in Categorys) {
                 var dm = new CategoryModel()
                 {
                     Id = d.Id,
                     Name = d.Name
                 };
                 data.Add(dm); 
             }*/
            return data;
        }
        public static void AddCategory(CategoryDetails dept)
        {
            var d = AutoMapper.Mapper.Map<CategoryDetails, Category>(dept);
            //var d = new Category() { Id = dept.Id, Name = dept.Name };
            CategoryRepo.AddCategory(d);
        }

        public static CategoryDetails GetCategoryDetail(int id)
        {
            var d = CategoryRepo.GetCategoryDetail(id);
            var deptdetail = AutoMapper.Mapper.Map<Category, CategoryDetails>(d);
            return deptdetail;
        }

        public static List<CategoryDetails> GetCategoryWithDetails()
        {
            var data = CategoryRepo.GetCategorys();
            var dDetails = AutoMapper.Mapper.Map<List<Category>, List<CategoryDetails>>(data);
            return dDetails;

        }


    }
}
