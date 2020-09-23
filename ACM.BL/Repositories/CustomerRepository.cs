using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL.Repositories
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)

        {
            //Create the instance of the customer class
            //Pass in the requested id
            Customer customer = new Customer(customerId);
            //Temp hard coded
            if (customerId == 1)
            {
                customer.EmailAddress = "aperkins@gmail.com";
                customer.FirstName = "Ann";
                customer.LastName = "Perkins";
            }
            return customer;
        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
 