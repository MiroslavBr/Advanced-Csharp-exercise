using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _10.ThePartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Func<string, Func<string, bool>>> filterBuilder = new()
            {
                ["Starts with"] = parameter =>
                {
                    return name => name.StartsWith(parameter);
                },
                ["Ends with"] = parameter =>
                {
                    return name => name.EndsWith(parameter);
                },
                ["Length"] = parameter =>
                {
                    return name => name.Length == int.Parse(parameter);
                },
                ["Contains"] = parameter =>
                {
                    return name => name.Contains(parameter);
                }
            };

            List<string> guests = Console.ReadLine().Split().ToList();

            Dictionary<(string filterType, string parameter), Func<string, bool>> activFilters = new();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] dataParts = command.Split(";");

                string action = dataParts[0];
                string filterType = dataParts[1];
                string parameter = dataParts[2];

                if (action == "Add filter")
                {
                    Func<string, bool> filter = filterBuilder[filterType](parameter);
                    activFilters[(filterType, parameter)]= filter;
                }
                else if (action == "Remove filter")
                {
                    activFilters.Remove((filterType, parameter));
                }
            }

            foreach(Func<string, bool> filter in activFilters.Values)
            {
                for (int i = guests.Count - 1; i >= 0; i--)
                {
                    if (filter(guests[i]))
                    {
                        guests.RemoveAt(i);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",guests));
        }
    }
}
