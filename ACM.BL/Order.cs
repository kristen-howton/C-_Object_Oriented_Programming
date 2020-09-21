using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTime OrderDate { get; set; }
        public int OrderId { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (DateTime(OrderDate == null)) isValid = false;

            return isValid;
        }
    }
}
