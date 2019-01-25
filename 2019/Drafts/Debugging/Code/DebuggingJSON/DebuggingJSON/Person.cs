using System.Collections.Generic;

namespace DebuggingJSON
{
    public class Person
    {
        public Person(string firstName, string lastName) : this(firstName, string.Empty, lastName)
        {
        }

        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            this.Age = age;
        }


        public string FirstName { get; }

        public string MiddleName { get;  }

        public string LastName { get; }

        public int Age { get; }

        public static IEnumerable<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person("Aayan", "Galodha", 1),
                new Person("Abhinav", "Galodha")
            };
        }

    }
}
