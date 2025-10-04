namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using FileStream partOneFileStream = new(partOneFilePath, FileMode.OpenOrCreate);
            using FileStream partTwoFileStream = new(partTwoFilePath, FileMode.OpenOrCreate);

            byte[] bytesFromImge = File.ReadAllBytes(sourceFilePath);


            int halfLenght = (int)Math.Ceiling((bytesFromImge.Length / 2.0m));
            byte[] firstBytesHalf = new byte[halfLenght];
            byte[] secondBytesHalf = new byte[bytesFromImge.Length / 2];

            for (int i = 0; i < halfLenght; i++)
            {
                firstBytesHalf[i] = bytesFromImge[i];
            }
            for (int i = halfLenght; i < bytesFromImge.Length; i++)
            {
                secondBytesHalf[i - halfLenght] = bytesFromImge[i];
            }
            partOneFileStream.Write(firstBytesHalf);
            partTwoFileStream.Write(secondBytesHalf);

        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using FileStream joinedFileStream = new(joinedFilePath, FileMode.OpenOrCreate);

            byte[] bytesPart = File.ReadAllBytes(partOneFilePath);

            joinedFileStream.Write(bytesPart);
            bytesPart = File.ReadAllBytes(partTwoFilePath);
            joinedFileStream.Write(bytesPart);
            joinedFileStream.Close();
        }
    }
}