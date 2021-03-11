using System;
using System.IO;

namespace MyLs
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";

            if (args.Length < 2)
            {
                path = Directory.GetCurrentDirectory();
            }
            else
            {
                path = args[1];
            }

            string[] theFiles = Directory.GetFiles(path);
            string[] theDirectories = Directory.GetDirectories(path);

            foreach (string dir in theDirectories)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                string dirNameOnly = dir.Replace(path + @"\", "");
                Console.WriteLine(dirNameOnly + "/");
            }

            foreach (string file in theFiles)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string fileNameOnly = file.Replace(path + @"\", "");
                Console.WriteLine(fileNameOnly);
            }
        }
    }
}