using System;
using System.Collections.Generic;

namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> brokeGuest = new();
            HashSet<string> VIPGuest = new();

            string data = string.Empty;
            static bool IsTheGuestVIP(char guestID)
            {
                return char.IsAsciiDigit(guestID) ? true : false;
            }
            while ((data = Console.ReadLine()) != "PARTY")
            {
                if (IsTheGuestVIP(data[0]))
                {
                    VIPGuest.Add(data);
                }
                else
                {
                    brokeGuest.Add(data);
                }
            }

            while ((data = Console.ReadLine()) != "END")
            {
                if (IsTheGuestVIP(data[0]))
                {
                    VIPGuest.Remove(data);
                }
                else
                {
                    brokeGuest.Remove(data);
                }
            }

            Console.WriteLine($"{VIPGuest.Count + brokeGuest.Count}" +
                $"\n{string.Join("\n", VIPGuest)}" +
                $"\n{string.Join("\n", brokeGuest)}");
        }
    }
}
