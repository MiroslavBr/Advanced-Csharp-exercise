namespace ExtractSpecialBytes
{
    using System;
    using System.IO;
    using System.Linq;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using FileStream stream = new(binaryFilePath, FileMode.Open);
            using FileStream streamOutput = new(outputPath, FileMode.Create);

            byte[] bytesFromImage = new byte[stream.Length];
            stream.Read(bytesFromImage);

            byte[] bytesFile = File.ReadAllLines(bytesFilePath).Select(byte.Parse).ToArray();

            foreach (byte bytes in bytesFile)
            {
                foreach (byte imageBytes in bytesFromImage)
                {
                    if (imageBytes == bytes)
                    {
                        streamOutput.WriteByte(bytes);
                    }
                }
            }
        }
    }
}
