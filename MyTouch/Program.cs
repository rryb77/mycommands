using System;
using System.IO;

namespace MyTouch
{
    class Program
    {
        static void Main(string[] args)
        {

            var filename = args[0];

            if (args.Length != 1)
            {
                Console.Error.WriteLine("USAGE: mytouch <filename>");
                Environment.Exit(1);
            }

            if (File.Exists(filename))
            {
                Console.WriteLine($"{filename} already exists, would you like to overwrite it? [Y/N]");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    File.Create($"{filename}");
                }
                else
                {
                    Environment.Exit(1);
                }
            }
            else
            {
                File.Create($"{filename}");
            }
        }
    }
}
