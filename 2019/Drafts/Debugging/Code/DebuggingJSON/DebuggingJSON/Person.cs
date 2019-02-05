using System.Collections.Generic;

namespace DebuggingJSON
{
    public class Person
    {
        public Person()
        {
            
        }

        public string FirstName { get; set;}

        public string LastName { get; set;}

        public int Age { get; set;}

        public Address Address { get; set; }

        public static IEnumerable<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person {FirstName = "Aayan", LastName = "Galodha", Age = 1, Address = Address.GetAddress()[0]},
                new Person { FirstName = "Abhinav", LastName = "Galodha", Address = Address.GetAddress()[1]}
            };
        }
    }
}
