namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            //  throw new NotImplementedException();

            using StreamReader reader = new(inputFilePath);

            HashSet<char> replaceble = new() { '-', ',', '.', '!', '?' };
            StringBuilder sb = new();
            int i = 1;
            while (!reader.EndOfStream)
            {

                char[] chars = reader.ReadLine().ToCharArray();
                if (i % 2 != 0)
                {
                    for (int j = 0; j < chars.Length; j++)
                    {
                        if (replaceble.Contains(chars[j]))
                        {
                            chars[j] = '@';
                        }
                    }
                    sb.AppendLine(string.Join("", chars));
                }
                i++;
            }
            
                return sb.ToString();
            
        }
    }
}
