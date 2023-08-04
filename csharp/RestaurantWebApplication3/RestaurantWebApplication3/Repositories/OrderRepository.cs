using RestaurantWebApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebApplication3.Repositories
{
    public class OrderRepository
    {
        private Model2 model1;

        public OrderRepository() 
        
        {
            model1=new Model2();


        }

        public bool AddOrder(OrderViewModel objOrderViewModel)
        {
            Order order = new Order();
            order.CustomerId = objOrderViewModel.CustomerId;
            order.FinalTotal = objOrderViewModel.FinalTotal;
            order.OrderDate=DateTime.Now;
            order.Ordernumber = string.Format("{0:ddmmyyyyhhmmss}", DateTime.Now);
            order.PaymentTypeId=objOrderViewModel.PaymentTypeId;
            model1.Orders.Add(order);
            model1.SaveChanges();
            int orderid=order.OrderId;
            foreach(var item in objOrderViewModel.IsOfOrderDetailViewModel)
            {
                Order_Details details = new Order_Details();
                details.OrderId = orderid;
                details.Discount = item.Discount;

                details.ItemID = item.ItemID;
                details.Total = item.Total;
                details.UnitPrice = item.UnitPrice;
                details.Quantity = (-1) * item.Quantity;
                model1.Order_Details.Add(details);
                model1.SaveChanges ();

                Transaction tr=new Transaction();
                tr.ItemId=item.ItemID;
                tr.Quantity = item.Quantity;
                tr.TransactionDate=DateTime.Now;
                tr.TypeId = 2;
                model1.Transactions.Add(tr);
                model1.SaveChanges () ; 
            }
            return true;
        }
    }
}