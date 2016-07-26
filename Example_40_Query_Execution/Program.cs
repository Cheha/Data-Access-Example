using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_40_Query_Execution
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

            IEnumerable<Person> sortedPersons = from person in persons
                                                orderby person.SecondName ascending
                                                select person;
            sortedPersons.Where(p => p.Age >= 20 && p.Age < 30);

            Console.WriteLine("sortedPersons - deffered execution:");
            foreach (Person person in sortedPersons)
                Console.WriteLine(person.SecondName + " " + person.FirstName);

            Console.WriteLine("sortedPersons - immediate execution:");
            List<Person> persons2 = sortedPersons.OrderByDescending(person => person.FirstName).ToList<Person>();

            foreach (Person person in persons2)
            {
                Console.WriteLine(person.SecondName + " " + person.FirstName);
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

