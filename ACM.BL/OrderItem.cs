using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }
        
        public Order Retrieve (int OrderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            if (PurchasePrice == null) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            return isValid;
        }
        
    }
}
