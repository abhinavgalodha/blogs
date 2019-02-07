using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebuggingJSON
{
    public class Address
    {
        public Address(string addressLine1, string city, string State, int zip) :
            this(addressLine1, string.Empty, city, State, zip)
        {
            
        }

        public Address(string addressLine1, string addressLine2, string city, string State, int zip)
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.Zip = zip;
        }

        public string AddressLine1 { get;set;}

        public string AddressLine2 { get;set;}

        public string City { get;set;}

        public string State { get;set;}

        public int Zip { get;set;}

        public static Address GetFirstAddress()
        {
            return GetAddress().FirstOrDefault();
        }

        public static List<Address> GetAddress()
        {
            return new List<Address>
            { new Address("1800 Continental Avenue",
                    "Austin",
                    "Texas",
                     60606),
                new Address(
                    "1800 Continental Avenue",
                    "Apt 456",
                    "Austin",
                    "Texas",
                    60606
                )
            };
        }

    }
}
