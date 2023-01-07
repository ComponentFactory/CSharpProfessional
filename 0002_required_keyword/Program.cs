using System.Diagnostics.CodeAnalysis;

namespace _0002_required_keyword
{
    class EntryClass
    {
        public class Person
        {
            public required string FirstName { get; init; }
            public required string LastName { get; init; }

            public Person()
            {
            }

            [SetsRequiredMembers]
            public Person(string fullName)
            {
                string[] parts = fullName.Split(' ');
                FirstName = parts[0];
                LastName = parts[1];
            }
        }

        public class Employee : Person
        {
            public required int Salary { get; init; }

            public Employee()
            {
            }

            [SetsRequiredMembers]
            public Employee(string fullName)
                : base(fullName)
            {
                Salary = 10000;
            }
        }

        static void Main(string[] _)
        {
            Person person1 = new("John Doe");
            Person person2 = new()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            Employee employee1 = new("John Doe");
            Employee employee2 = new()
            {
                FirstName = "John",
                LastName = "Doe",
                Salary = 11000
            };
        }
    }
}

