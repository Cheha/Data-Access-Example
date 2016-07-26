using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_39_Linq_Extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person> { 
                new Person { Id = 1, FirstName = "John", SecondName = "Stevens", Age = 33 },
                new Person { Id = 2, FirstName = "Bob", SecondName = "Walters", Age = 20 },
                new Person { Id = 3, FirstName = "Samantha", SecondName = "Smith", Age = 27 },
                new Person { Id = 4, FirstName = "George", SecondName = "Springwater", Age = 44 },
                new Person { Id = 5, FirstName = "Barbara", SecondName = "Lucas", Age = 46 }
            };

            var sortedPersons = persons.Where(p => p.Age >= 20 && p.Age <= 30).
                                    OrderBy(p => p.SecondName).
                                    OrderByDescending(p => p.FirstName).
                                    Select(p => p);
            Console.WriteLine("sortedPersons: ");
            foreach (var person in sortedPersons) {
                Console.WriteLine("{0} {1}", person.FirstName, person.SecondName);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
    }
}
