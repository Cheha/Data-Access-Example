using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_36_Grouping
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

            var sortedGroups = from person in persons
                               orderby person.FirstName, person.SecondName
                               group person by person.SecondName[0] into newGroup
                               orderby newGroup.Key
                               select newGroup;
            Console.WriteLine("sortedGroups: ");
            foreach (var personGroup in sortedGroups) {
                Console.WriteLine(personGroup.Key);
                foreach (var person in personGroup) {
                    Console.WriteLine("{0} {1}", person.FirstName, person.SecondName);
                }
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
