using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vlogger> vloggers = new();

            WorkingWithVloggers(vloggers);

            vloggers = OrderDic(vloggers);
            PrintOutput(vloggers);

        }

        private static void WorkingWithVloggers(Dictionary<string, Vlogger> vloggers)
        {
            string data = string.Empty;
            while ((data = Console.ReadLine()) != "Statistics")
            {
                string[] dataParts = data.Split();
                string vloggerName = dataParts[0];
                string command = dataParts[1];

                if (command == "joined")
                {
                    AddingVloggerToDic(vloggers, vloggerName);
                }
                else if (command == "followed")
                {
                    FollowingOtherVlogger(vloggers, dataParts, vloggerName);
                }
            }
        }

        private static void AddingVloggerToDic(Dictionary<string, Vlogger> vloggers, string vloggerName)
        {
            if (!vloggers.ContainsKey(vloggerName))
            {
                Vlogger vlogger = new(vloggerName);
                vloggers.Add(vloggerName, vlogger);
            }
        }

        private static void FollowingOtherVlogger(Dictionary<string, Vlogger> vloggers, string[] dataParts, string vloggerName)
        {
            string secondVlogger = dataParts[2];
            if (vloggers.ContainsKey(vloggerName) &&
                vloggers.ContainsKey(secondVlogger))
            {
                if (!(secondVlogger == vloggerName))
                {
                    if (!vloggers[secondVlogger].Followers.Contains(vloggerName))
                    {
                        vloggers[secondVlogger].Followers.Add(vloggerName);
                        vloggers[vloggerName].Following.Add(secondVlogger);
                    }
                }
            }
        }

        private static Dictionary<string, Vlogger> OrderDic(Dictionary<string, Vlogger> vloggers)
        {
            vloggers = vloggers.OrderByDescending(vloger => vloger.Value.Followers.Count)
                              .ThenBy(vloger => vloger.Value.Following.Count)
                              .ToDictionary();
            return vloggers;
        }

        private static void PrintOutput(Dictionary<string, Vlogger> vloggers)
        {
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int i = 1;
            foreach (Vlogger vlogger in vloggers.Values)
            {
                if (i == 1)
                {
                    Console.WriteLine($"1. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following");
                    foreach (var followers in vlogger.Followers)
                    {
                        Console.WriteLine($"*  {followers.ToString()}");
                    }
                }
                else
                {
                    Console.WriteLine($"{i}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following");
                }
                i++;
            }
        }
    }

    class Vlogger
    {
        public Vlogger(string name)
        {
            Name = name;
            Followers = new();
            Following = new();
        }
        public string Name { get; set; }
        public SortedSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }
    }
}
