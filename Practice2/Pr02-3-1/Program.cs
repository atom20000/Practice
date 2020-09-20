using System;
using System.IO;
using System.IO.Compression;

namespace Pr02_3_1
{
    class Program
    {
        static void CompressFile(string inFilename,string outFilename)
        {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.OpenWrite(outFilename);
            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            int theByte = sourceFile.ReadByte();
            while (theByte != -1)
            {
                compStream.WriteByte((byte)theByte); theByte = sourceFile.ReadByte();
            }
            sourceFile.Close();
            destFile.Close();
            //compStream.Close();
        }

        static void Main(string[] args)
        {
            CompressFile(@"D:\boot.ini", @"D:\boot.ini.gz");
        }
    }
}
