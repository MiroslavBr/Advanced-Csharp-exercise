namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            //throw new NotImplementedException();
            string[] lines = File.ReadAllLines(inputFilePath);
            StringBuilder stringBuilder = new();
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                MatchCollection mch =Regex.Matches(line, @"[A-Za-z]");
                int lettersCount = mch.Count;
                mch =Regex.Matches(line, @"[^A-Za-z\d\s]");
                int punctuationCount = mch.Count;

                stringBuilder.AppendLine($"Line {i + 1}: {line} ({lettersCount})({punctuationCount})");
            }
            // File.Create(outputFilePath);
            File.WriteAllText(outputFilePath, stringBuilder.ToString());
        }
    }
}
