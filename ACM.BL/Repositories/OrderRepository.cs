using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL.Repositories
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)

        {
            //Create the instance of the customer class
            //Pass in the requested id
            Order order = new Order(orderId);
            //Temp hard coded
            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
         
            }
            return order;
        }
        public bool Save(Order order)
        {
            return true;
        }
    }
}
