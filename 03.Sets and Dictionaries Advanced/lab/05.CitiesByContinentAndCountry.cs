using System;
using System.Collections.Generic;

namespace _05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfinput = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> citiesContryAndContinents = new();
            for (int i = 0; i < numberOfinput; i++)
            {
                string[] dataParts = Console.ReadLine().Split();
                string continent = dataParts[0];
                string country = dataParts[1];
                string city = dataParts[2];

                if (!citiesContryAndContinents.ContainsKey(continent))
                {
                    citiesContryAndContinents[continent] = new Dictionary<string, List<string>>();

                }

                if (!citiesContryAndContinents[continent].ContainsKey(country))
                {
                    citiesContryAndContinents[continent][country] = new List<string>();
                }

                citiesContryAndContinents[continent][country].Add(city);
            }

            foreach (string continent in citiesContryAndContinents.Keys)
            {
                Console.WriteLine($"{continent}:");
                foreach (KeyValuePair<string,List<string>> citiesAndCountry in citiesContryAndContinents[continent])
                {
                    Console.WriteLine($"{citiesAndCountry.Key} -> {string.Join(", ",citiesAndCountry.Value)}");
                }
            }
        }
    }
}
