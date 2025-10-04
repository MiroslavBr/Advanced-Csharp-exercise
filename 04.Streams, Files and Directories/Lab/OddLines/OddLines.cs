namespace OddLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security.Cryptography.X509Certificates;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            /*List<string> oddLines = new();
            using (StreamReader reader = new(inputFilePath))
            {
                int count = 0;
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    if (count % 2 == 1)
                    {
                        oddLines.Add(reader.ReadLine());
                    }
                }
            }

            using (StreamWriter writer = new(outputFilePath))
            {
                foreach (string line in oddLines)
                {
                    writer.WriteLine(line);
                } 
            }*/
            using StreamReader reader = new(inputFilePath);
            using StreamWriter writer = new(outputFilePath);

            int count = 0;
            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }

                if (count % 2 == 1)
                {
                    writer.WriteLine(line);
                }
                count++;
            }
        }
    }
}
