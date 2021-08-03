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
        public static List<CategoryModel> GetCategories()
        {
            var Categorys = CategoryRepo.GetCategories();
            var data = AutoMapper.Mapper.Map<List<Category>, List<CategoryModel>>(Categorys);
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
        public static void AddCategory(CategoryModel cat)
        {
            var d = AutoMapper.Mapper.Map<CategoryModel, Category>(cat);
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
            var data = CategoryRepo.GetCategories();
            var dDetails = AutoMapper.Mapper.Map<List<Category>, List<CategoryDetails>>(data);
            return dDetails;

        }

    }
}
