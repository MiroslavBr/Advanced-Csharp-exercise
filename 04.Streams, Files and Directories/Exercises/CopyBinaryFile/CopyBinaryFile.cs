namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using FileStream read = new(inputFilePath, FileMode.Open, FileAccess.Read);
            using FileStream write = new(outputFilePath, FileMode.Create, FileAccess.Write);

            while (true)
            {
                byte[] buffer = new byte[1024];

                int readedBytes = read.Read(buffer);
                if (readedBytes == 0)
                {
                    break;
                }
                write.Write(buffer, 0, readedBytes);
            }
            read.Close();
            write.Close();

            
            //read.CopyTo(write);
        }
    }
}
