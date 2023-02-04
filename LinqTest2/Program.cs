using System;
using System.Linq;
namespace LinqTest2
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(Person? other)
        {
            //if (this.Salary < other.Salary)
            //    return -1;

            //if (this.Salary > other.Salary)
            //    return 1;

            //return 0;

            return this.Name.CompareTo(other.Name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person()
            {
                Name = "Ararat",
                Surname = "Smith",
                Salary = 1000m
            });

            people.Add(new Person()
            {
                Name = "Babken",
                Surname = "Rostan",
                Salary = 1000m
            });

            people.Add(new Person()
            {
                Name = "Centurios",
                Surname = "Zetta Johns",
                Salary = 1600m
            });

            people.Add(new Person()
            {
                Name = "Ketrine",
                Surname = "Vardanyan",
                Salary = 750m
            });

            people.Add(new Person()
            {
                Name = "Qristine",
                Surname = "Babayan",
                Salary = 2000m
            });

            people.Add(new Person()
            {
                Name = "Vazgen",
                Surname = "Petrosyan",
                Salary = 1600m
            });

            var names =
                from person in people
                where person.Salary >= 1000
                orderby person.Salary, person.Name descending
                select new { Anun = person.Name, Salary = person.Salary };

            Console.WriteLine(names);

            //names = people
            //     .Where(p => p.Salary >= 1000)
            //     .OrderBy(p => p.Name)
            //     .ThenBy(p => p.Salary)
            //     .Select(p => new { Anun = p.Name, Salary = p.Salary });

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}