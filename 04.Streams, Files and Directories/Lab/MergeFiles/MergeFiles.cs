namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using StreamWriter streamWriterOutput = new(outputFilePath);

            string[] input1 = File.ReadAllLines(firstInputFilePath);
            string[] input2 = File.ReadAllLines(secondInputFilePath);

            for (int i = 0; i < Math.Max(input1.Length, input2.Length); i++)
            {
                if (input1.Length > i)
                {
                    streamWriterOutput.WriteLine(input1[i]);
                }
                if (input2.Length > i)
                {
                    streamWriterOutput.WriteLine(input2[i]);
                }
            }

            streamWriterOutput.Close();

        }
    }
}
