using System;
using System.IO;

namespace Pr02_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = File.CreateText(@"E:\newfile.txt");
            writer.WriteLine("This is my new file");
            writer.WriteLine("Do you like its format?"); 
            writer.Close();
            StreamReader reader = File.OpenText(@"E:\newfile.txt");
            string contents = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(contents);
        }
    }
}
