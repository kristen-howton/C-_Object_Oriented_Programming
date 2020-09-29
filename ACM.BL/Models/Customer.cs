using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        //constructor chaining, 0 because had id parameter
        //gets this constructor to call the other constructor
        //default constructor calls the parameterized constructor
        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            //for list default value is null
            AddressList = new List<Address>();
        }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        //read only property FullName
        public string FullName
        {
            get
            { 
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }

        }

        public List<Address> AddressList { get; set; }
        
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        //static belongs to class itself, must use class name
        public static int InstanceCount { get; set; }
    }


}