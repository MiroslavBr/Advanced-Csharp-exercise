using System;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = ReadPeople();

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter = CreateFilter(condition, ageThreshold);

            Action<Person> printer = CreatePrinter(format);
            PrintFilteredPeople(people, filter, printer);
        }

        private static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            foreach (Person person in people)
            {
                if (filter(person))
                {
                    printer(person);
                }
            }
        }

        private static Action<Person> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name age":
                    return p => Console.WriteLine($"{p.Name} - {p.Age}");
                case "name":
                    return p => Console.WriteLine($"{p.Name}");
                case "age":
                    return p => Console.WriteLine($"{p.Age}");
            }


            throw new NotImplementedException();
        }

        private static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
        {
            if (condition == "older")
            {
                return person => person.Age >= ageThreshold;
            }
            else
            {
                return person => person.Age < ageThreshold;
            }
        }

        static List<Person> ReadPeople()
        {
            List<Person> people = new();
            int dataCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < dataCount; i++)
            {
                string[] dataParts = Console.ReadLine().Split(", ");
                Person person = new(dataParts[0], dataParts[1]);
                people.Add(person);
            }
            return people;
        }
    }
    class Person
    {
        public Person(string name, string age)
        {
            Name = name;
            Age = int.Parse(age);
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
