using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebuggingJSON
{
    public class Person
    {
        public string FirstName {get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }

        public static IEnumerable<Person> Get()
        {
        }

    }
}
