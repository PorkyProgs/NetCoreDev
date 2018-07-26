using System;
using System.IO;
using System.Text;

namespace SelectionStatements
{
    class Program
    {
        public static void WriteLine(string s) => Console.WriteLine(s);
        static void Main(string[] args)
        {
            // string path = "/Users/markjprice/Code/Chapter03";
            // macOS
            string path = @"C:\Depo\RB\Adam\NetCoreDev\C3"; // Windows

            Stream s = null;

            try
            {
                s = File.Open(
              Path.Combine(path, "\asdasd\file.txt"),
              FileMode.OpenOrCreate);
            }
            catch { }
            
            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    writeableFile.WriteLine("The stream is to a file that I can write to.");      
                    break;
                case FileStream readOnlyFile:
                    WriteLine("The stream is to a read-only file.");
                    break;
                case MemoryStream ms:
                    WriteLine("The stream is to a memory address.");
                    break;
                default: // always evaluated last despite its current position
                    WriteLine("The stream is some other type.");
                    break;
                case null:
                    WriteLine("The stream is null.");
                    break;
            }
        }
    }

    public static class FileStreamExtension
    {
        public static void WriteLine(this FileStream fileStream, string s)
        {
            var bytes = Encoding.UTF8.GetBytes(s);
            fileStream.Write(bytes, 0, bytes.Length);
            fileStream.Flush();
        }
    }
}
