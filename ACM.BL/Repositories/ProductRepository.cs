using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL.Repositories
{
   public class ProductRepository
   {
        public Product Retrieve(int productId)

        {
            Product product = new Product(productId);
            //Temp hard coded
            if (productId == 1)
            {
                product.ProductName = "chips";
                product.Description = "bag of chips description";
                product.CurrentPrice = 15.96M;
            }

             Object myObject = new Object();
             Console.WriteLine($"Object: {myObject.ToString()}");
             Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }
        public bool Save(Product product)
        {
            return true;
        }

       
   }
}
