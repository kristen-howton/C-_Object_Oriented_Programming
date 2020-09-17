﻿using System;

namespace ACM.BL
{
    public class Customer
    {

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public  string  EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
    }
}
    