using System.Collections.Generic;

namespace DebuggingJSON
{
    public class Person
    {
        public Person()
        {
            
        }

        //private Person(string firstName, string lastName) : this(firstName, string.Empty, lastName)
        //{
        //}

        //private Person(string firstName, string middleName, string lastName)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //}

        //public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        //{
        //    this.Age = age;
        //}


        public string FirstName { get; set;}

        public string MiddleName { get;  set;}

        public string LastName { get; set;}

        public int Age { get; set;}

        //public Address Address { get; }

        public static IEnumerable<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person {FirstName = "Aayan", LastName = "Galodha", Age = 1},
                new Person { FirstName = "Abhinav", LastName = "Galodha"}
            };
        }
    }
}
