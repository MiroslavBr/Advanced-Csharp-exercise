using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfUsernames = int.Parse(Console.ReadLine());
            HashSet<string> users = new();
            for (int i = 0; i < numberOfUsernames; i++)
            {
                users.Add(Console.ReadLine());
            }
            
            foreach (string user in users)
            {
                Console.WriteLine(user);
            }



        }
    }
}
