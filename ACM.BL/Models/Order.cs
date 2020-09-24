using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; }
        public double PurchasePrice { get; set; }
        //great for different time zones
        public DateTimeOffset? OrderDate { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
