using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Where(word =>char.IsUpper(word[0]))
                .ToArray();

            //Func<string, bool> func = word => char.IsUpper(word[0]);
          
            //foreach (string word in words)
            //{
            //    if(func(word))
            //        Console.WriteLine(word);
            //}

            Console.WriteLine(string.Join("\n",words));


        }
    }
}
