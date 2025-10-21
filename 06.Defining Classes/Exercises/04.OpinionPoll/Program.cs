using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            List<Person> people = new();
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] data = Console.ReadLine().Split();
                Person person = new(int.Parse(data[1]), data[0]);
                people.Add(person);
            }

            people = people.Where(p=>p.Age>30).OrderBy(n=>n.Name).ToList();
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
