using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderDetailsService
    {
        public static List<OrderDetailModel> GetOrderDetails(string invoice)
        {
            var orders = OrderDetailsRepo.GetOrderDetails(invoice);
            var data = AutoMapper.Mapper.Map<List<OrderDetail>, List<OrderDetailModel>>(orders);
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
        public static void PlaceOrder(List<CartTable> list, string invoice)
        {
            

            



            foreach (var d in list)
            {
                OrderDetailModel od = new OrderDetailModel();
                od.ProductId = d.ProductId;
                od.Qty = d.Qty;
                od.InvoiceNumber = invoice;
                od.TotalPrice = d.TotalPrice;
                AddOrderDetails(od);

                

            }

            CartRepo.CleanCart();
            


        }
        public static void AddOrderDetails(OrderDetailModel order)
        {
            var d = AutoMapper.Mapper.Map<OrderDetailModel, OrderDetail>(order);
            //var d = new Category() { Id = dept.Id, Name = dept.Name };
            OrderDetailsRepo.AddOrderDetails(d);
        }

      

    }
}
