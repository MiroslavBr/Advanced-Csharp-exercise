namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            //readwords
            string[] words = File.ReadAllText(wordsFilePath).Split();
            Dictionary<string, int> wordsCount = new();
            foreach (string word in words)
            {
                wordsCount[word.ToLower()] = 0;
            }

            //readtext
            string[] textLines = File.ReadAllLines(textFilePath);
            foreach (string line in textLines)
            {
                char[] separators = { ',', ' ' };
                //string[] wordsOnLine = Regex.Split(line, @"[^A-Za-z]");
                //MatchCollection wordsOnLine = Regex.Matches(line, @"[A-Za-z]+");
                string[] wordsOnLine = Regex.Matches(line, @"[A-Za-z]+").Select(x => x.Value.ToLower()).ToArray();

                foreach (string word in wordsOnLine)
                {
                    if (wordsCount.ContainsKey(word))
                    {
                        wordsCount[word]++;
                    }
                }
            }

            //write text
            var sortedWordsCount = wordsCount.OrderByDescending(x => x.Value);
            string output = string.Empty;
            foreach (KeyValuePair<string, int> word in sortedWordsCount)
            {
                output += $"{word.Key} - {word.Value}\n";
            }
            File.WriteAllText(outputFilePath, output);
        }
    }
}
