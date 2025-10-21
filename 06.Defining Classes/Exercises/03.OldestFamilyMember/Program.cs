using System;
using System.Globalization;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] data = Console.ReadLine().Split();
                Person person = new(int.Parse(data[1]), data[0]);
                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

        }
    }
}
