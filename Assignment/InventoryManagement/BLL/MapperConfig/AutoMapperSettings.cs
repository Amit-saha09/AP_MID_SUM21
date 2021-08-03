using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings: Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<CategoryModel, Category>().ForMember(e => e.Products, d => d.Ignore());
            CreateMap<Category, CategoryModel>();
            CreateMap<Category, CategoryDetails>();
            CreateMap<CartTable, CartModel>();
            CreateMap<CartModel, CartTable>();

            CreateMap<ProductModel, Product>().ForMember(e => e.Category, sm => sm.Ignore());
            CreateMap<OrderDetailModel, OrderDetail>().ForMember(e => e.Product, d => d.Ignore());
            CreateMap<OrderDetail, OrderDetailModel>();

        }
    }
}
