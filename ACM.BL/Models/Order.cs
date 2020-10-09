using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public Order(): this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int OrderId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; }
        public double PurchasePrice { get; set; }
        public int CustomerType { get; set; }
        //great for different time zones
        public DateTimeOffset? OrderDate { get; set; }

        public override string ToString()
        {
            return $"{OrderDate.Value.Date} ({OrderId})";
        }
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
