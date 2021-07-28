
using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InventoryManagement.Controllers
{
    public class CategoryController : ApiController
    {
        [Route("api/Category/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return CategoryService.GetCategoryNames();
        }
        [Route("api/Category/GetAll")]
        [HttpGet]
        public List<CategoryDetails> GetAllCategorys()
        {
            return CategoryService.GetCategorys();
        }
        [Route("api/Category/Add")]
        [HttpPost]
        public void Add(CategoryDetails cat)
        {
            CategoryService.AddCategory(cat);
        }
        [Route("api/Category/All/Details")]
        public List<CategoryDetails> GetCategoryWithDetails()
        {
            return CategoryService.GetCategoryWithDetails();
        }
        [Route("api/Category/{id}/Details")]
        public CategoryDetails GetCategoryDetail(int id)
        {
            return CategoryService.GetCategoryDetail(id);
        }

    }
}
