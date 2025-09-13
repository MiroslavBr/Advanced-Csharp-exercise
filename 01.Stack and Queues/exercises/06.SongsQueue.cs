using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new(Console.ReadLine().Split(", "));

            string input = Console.ReadLine();
            while (songs.Count>0)
            {
                string command = input.Split(" ")[0];
                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Add")
                {
                    string songName = input.Substring(input.IndexOf(" ")+1);
                    if (songs.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }else
                    {
                        songs.Enqueue(songName);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ",songs));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
