using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.IO.Compression;

namespace Pr02_3_2
{
    class Program
    {
        static void UncompressFile(string inFilename,string outFilename)
        {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.OpenWrite(outFilename);
            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            int theByte =compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte); 
                theByte = compStream.ReadByte();
            }
            sourceFile.Close();
            destFile.Close();
            compStream.Close();
        }
        static void Main(string[] args)
        {
            UncompressFile(@"c:\boot.ini.gz", @"c:\boot.ini.test");
        }
    }
}
