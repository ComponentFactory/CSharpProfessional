using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace __0003_record_internals
{
    class StartupClass
    {
        // public record class Person(string Name, int Age);

        public class Person : IEquatable<Person>
        {
            private readonly string _name;
            private readonly int _age;

            public string Name
            {
                get { return _name; }
                init { _name = value; }
            }

            public int Age
            {
                get { return _age; }
                init { _age = value; }
            }           

            public Person(string name, int age)
                : base()
            {
                _name = name;
                _age = age;
            }

            public override string ToString()
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(nameof(Person));
                builder.Append(" { ");

                if (this.PrintMembers(builder))
                    builder.Append(' ');

                builder.Append('}');
                return builder.ToString();
            }

            protected virtual bool PrintMembers(StringBuilder builder)
            {
                builder.Append("Name = ");
                builder.Append(Name);
                builder.Append(", Age = ");
                builder.Append(Age.ToString());
                return true;
            }       

            protected virtual Type EqualityContract
            {
                get { return typeof(Person); }
            }

            public override int GetHashCode()
            {
                return (EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 +
                        EqualityComparer<string>.Default.GetHashCode(_name)) * -1521134295 +
                        EqualityComparer<int>.Default.GetHashCode(_age);
            }            

            public virtual bool Equals(Person? other)
            {
                if ((object?)this == (object?)other)
                    return true;

                return other != null &&
                       EqualityContract == other.EqualityContract &&
                       EqualityComparer<string>.Default.Equals(_name, other._name) &&
                       EqualityComparer<int>.Default.Equals(_age, other._age);
            }
            
            public override bool Equals(object? obj)
            {
                return Equals(obj as Person);
            }

            public static bool operator ==(Person? left, Person? right)
            {
                if ((object?)left == (object?)right)
                    return true;

                return (object?)left != null && left.Equals(right);
            }

            public static bool operator !=(Person? left, Person? right)
            {
                return !(left == right);
            }

            public void Deconstruct(out string name, out int age)
            {
                name = this.Name;
                age = this.Age;
            }

            public virtual Person Clone()
            {
                return new Person(this);
            }

            protected Person(Person original)
                : base()
            {
                _name = original._name;
                _age = original._age;
            }  
        }

        static void Main(string[] _)
        {
            Person john = new("John Doe", 42);
            Person jane = new("Jane Doe", 38);
            Console.WriteLine($"john = {john}");
            Console.WriteLine($"jane = {jane}");

            Console.WriteLine($"john Equals jane : {john.Equals((object)jane)}");
            Console.WriteLine($"john Equals jane : {john.Equals(jane)}");
            Console.WriteLine($"john == jane : {john == jane}");
            Console.WriteLine($"john != jane : {john != jane}");

            (var name, var age) = john;
            Console.WriteLine($"john destructor name:{name} age:{age}");        

            //-----------------------------------------------------
            // This code only works with the original record class
            //-----------------------------------------------------
            // Person alice = jane with { Name = "Alice Doe" };
            // Console.WriteLine($"alice = {alice}");

            // Console.WriteLine($"\nMethods");
            // foreach (var mi in typeof(Person).GetMethods())
            //     Console.WriteLine(mi.Name);
        }
    }
}

