using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL.MapperConfig
{
    public class AutoMapperSetting:Profile
    {
        public AutoMapperSetting()
        {
            CreateMap<CategoryDetails, Category>().ForMember(e => e.Products, d => d.Ignore());
            CreateMap<Category, CategoryDetails>();
            CreateMap<Category, CategoryWithProducts>();

            CreateMap<ProductDetails, Product>().ForMember(e => e.Category, sm => sm.Ignore());

        }

        
    }
}
