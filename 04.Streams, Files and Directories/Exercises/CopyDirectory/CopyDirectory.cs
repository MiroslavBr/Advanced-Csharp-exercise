namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            DirectoryInfo directoryInfoInput = new(inputPath);
            DirectoryInfo directoryInfoOutput = new(outputPath);
            if (directoryInfoOutput.Exists) directoryInfoOutput.Delete(true);
            directoryInfoOutput.Create();
            
            directoryInfoOutput.Create();

            foreach (FileInfo file in directoryInfoInput.GetFiles())
            {
                Console.WriteLine(file.Name);
                string path = Path.Combine(outputPath, file.Name);
                file.CopyTo(path);
            }

        }
    }
}
