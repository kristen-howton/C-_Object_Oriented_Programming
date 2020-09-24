using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL.Repositories
{
    class AddressRepository
    {

        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressId = 1;
                address.StreetLine1 = "111 Fake Address";
                address.StreetLine2 = "Apt 3";
                address.City = "Pawnee";
                address.State = "PA";
                address.Country = "Earth";
                address.PostalCode = "42101";
            }
            return address;
        }
        
        

    } 
}

