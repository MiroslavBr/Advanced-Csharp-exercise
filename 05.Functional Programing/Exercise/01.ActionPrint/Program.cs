using System;

namespace _01.ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            ////first way
            //Action<string> printWord = word => Console.WriteLine(word);
            //foreach (string word in words)
            //{
            //    printWord(word);
            //}

            ////second way
            //PrintWord(words);

            ////thurd way
            Action<string[], int > action = PrintWord;
            action(words,0);
 
            

        }

        static void PrintWord(string[] words, int i = 0)
        {

            if (words.Length > i)
            {
                Console.WriteLine(words[i]);
                i++;
                PrintWord(words, i);
            }

            return;
        }
    }
}
