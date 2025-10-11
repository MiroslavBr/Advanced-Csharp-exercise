using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace _09.PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Func<string, Predicate<string>>> predicateBuilder = new()
            {
                ["StartsWith"] = parameter =>
                {
                    return name => name.StartsWith(parameter);
                },
                ["EndsWith"] = parameter =>
                {
                    return name => name.EndsWith(parameter);
                },
                ["Length"] = parameter =>
                {
                    return name => name.Length == int.Parse(parameter);
                }
            };




            Dictionary<string, Action<List<string>, Predicate<string>>> action = new()
            {
                ["Remove"] = (list, predicate) =>
                {
                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        if (predicate(list[i]))
                        {
                            list.RemoveAt(i);
                        }
                    }
                },
                ["Double"] = (list, predicate) =>
                {
                    for (int i = list.Count-1; i >=0; i--)
                    {
                        if (predicate(list[i]))
                        {
                            list.Insert(i, list[i]);
                        }
                    }
                }
            };

            List<string> guestList = Console.ReadLine().Split().ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] data = command.Split();

                string operation = data[0];
                string criteria = data[1];
                string parameter = data[2];

               

                Predicate<string> predicate = predicateBuilder[criteria](parameter);
                action[operation](guestList, predicate);


            }

            if (guestList.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", guestList)} are going to the party!");
            }
        }



    }
}
