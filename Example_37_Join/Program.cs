using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_37_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person> { 
                new Person { Id = 1, FirstName = "John", SecondName = "Stevens", Age = 33, TeamId = 10 },
                new Person { Id = 2, FirstName = "Bob", SecondName = "Walters", Age = 20, TeamId = 20 },
                new Person { Id = 3, FirstName = "Samantha", SecondName = "Smith", Age = 27, TeamId = 10 },
                new Person { Id = 4, FirstName = "George", SecondName = "Springwater", Age = 44, TeamId = 20 },
                new Person { Id = 5, FirstName = "Barbara", SecondName = "Lucas", Age = 46, TeamId = 10 }
            };

            var teams = new List<Team> {
                new Team { Id = 10, Name = "Blue" },
                new Team { Id = 20, Name = "Red" }
            };

            //
            var innerQuery = from team in teams
                             join p in persons on team.Id equals p.TeamId
                             select new { FirstName = p.FirstName, SecondName = p.SecondName, Team = team.Name };
            Console.WriteLine("Simple join");
            foreach (var item in innerQuery) {
                Console.WriteLine("Player {0} {1} is from {2} team", item.FirstName, item.SecondName, item.Team);
            }

            //
            var groupJoin = from t in teams
                            join p in persons on t.Id equals p.TeamId into pGroup
                            select pGroup;
            Console.WriteLine("Group join");
            foreach (var pGrouping in groupJoin) {
                Console.WriteLine("Group: ");
                foreach (var item in pGrouping) {
                    Console.WriteLine("Player {0} {1} is from team with id {2}", item.FirstName, item.SecondName, item.TeamId);
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
        public int TeamId { get; set; }
    }

    class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
