using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.EvenTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfData = int.Parse(Console.ReadLine());
            Dictionary<int, int> frequencyOfnumbers = new();

            for (int i = 0; i < numberOfData; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!frequencyOfnumbers.ContainsKey(number))
                {
                    frequencyOfnumbers[number] = 0;
                }
                frequencyOfnumbers[number]++;
            }
            foreach ((int key , int value) in frequencyOfnumbers)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(key);break;
                }
            }

            
        }
    }
}
