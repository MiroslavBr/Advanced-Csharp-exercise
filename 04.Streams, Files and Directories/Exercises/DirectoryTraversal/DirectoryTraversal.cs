namespace DirectoryTraversal
{
    using System;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            DirectoryInfo directoryInfo = new(inputFolderPath);
            StringBuilder sb = new StringBuilder();
            Dictionary<string, Dictionary<string, decimal>> files = new();
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                string currentFileType = file.Extension;
                string currentFileName = file.Name;
                decimal currentFileSize = file.Length / 1024.0m; 
                if (!files.ContainsKey(currentFileType))
                {
                    files[currentFileType] = new();
                }

                files[currentFileType].Add(currentFileName, currentFileSize);
            }

            foreach (string key in files.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key).Keys)
            {
                sb.AppendLine(key);
                foreach (KeyValuePair<string, decimal> fileNameAndSize in files[key].OrderByDescending(x => x.Value))
                {
                    sb.AppendLine($"--{fileNameAndSize.Key} - {fileNameAndSize.Value}kb");
                }
            }

            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}{reportFileName}";
            using StreamWriter writer = new(path);
            //using FileStream outputWriter = new($@"C: \Users\{directoryInfo.Name}\Desktop{reportFileName}", FileMode.Create, FileAccess.Write);

            writer.Write(textContent);
            
        }
    }
}
