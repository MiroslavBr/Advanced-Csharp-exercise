using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumberOfCommands = int.Parse(Console.ReadLine());

            string output = string.Empty;

            Stack<string> changeLog = new();
            changeLog.Push(output);
            for (int i = 0; i < NumberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                StringBuilder sb = new StringBuilder(output);
                if (command[0] == "1")
                {
                    sb.Append(command[1]);
                    changeLog.Push(sb.ToString());

                }
                else if (command[0] == "2")
                {
                    int count = int.Parse(command[1]);
                    if (sb.Length > count)
                    {
                        sb.Remove(sb.Length - count, count);
                    }
                    else
                    {
                        sb.Clear();
                    }
                    changeLog.Push(sb.ToString());

                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(sb[index-1]);
                }
                else if (command[0] == "4")
                {
                    if (changeLog.Count > 1)
                    {
                        changeLog.Pop();
                        sb = new(changeLog.Peek());
                    }
                }
                output = sb.ToString();
            }
        }
    }
}
