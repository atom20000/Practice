using System.IO;
using System;
namespace Pr02_1_1
{
    class Program
    {
        static void ShowDirectory(DirectoryInfo dir)
        {
            // Показать все файлы
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine("File: {0}", file.FullName);
            }
            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                ShowDirectory(subDir);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory);
            ShowDirectory(dir);
        }
    }
}
