using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderService
    {
       /* public static List<string> GetCa()
        {
            return CategorRepo.GetCategoryNames();
        }*/
        public static List<OrderModel> GetOders()
        {
            var orders = OrderRepo.GetOrders();
            var data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(orders);
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
        public static void CreateOrder()
        {
            Random r = new Random();
            int num = r.Next(52364, 1023652);
            string invoice = num + "abc";
            var order = new OrderModel();

            order.InvoiceNumber = invoice;

            var cart = CartRepo.GetCarts();

            var total = 0;

            foreach (var e in cart) 
            {
                total = total + e.TotalPrice;

            }
            order.TotalPrice = total;
            order.DateTime = DateTime.Now;


            var d = AutoMapper.Mapper.Map<OrderModel, Order>(order);
            //var d = new Category() { Id = dept.Id, Name = dept.Name };
            OrderRepo.CreateOrder(d);

            OrderDetailsService.PlaceOrder(cart,invoice);
        }

        public static OrderModel GetOrder(string invoice)
        {
            var d = OrderRepo.GetOrder(invoice);
            var deptdetail = AutoMapper.Mapper.Map<Order, OrderModel>(d);
            return deptdetail;
        }

       
    }
}
