using System;
using System.Collections.Generic;
using System.IO;

namespace MySort
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Error.WriteLine("USAGE: mysort <filename>");
                Environment.Exit(1);
            }

            var filename = args[0];

            if (!File.Exists(filename))
            {
                Console.Error.WriteLine($"No such file: {filename}");
                Environment.Exit(1);
            }

            using var file = new StreamReader(filename);
            List<string> listOfLines = new List<string>();

            var reader = new StreamReader(filename);

            while (reader.ReadLine() != null)
            {
                string line = file.ReadLine();
                listOfLines.Add(line);
            }

            listOfLines.Sort();

            foreach (string line in listOfLines)
            {
                Console.WriteLine(line);
            }
            
        }
    }
}
