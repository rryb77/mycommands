using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

const int LINE_COUNT = 10;

if (args.Length != 1)
{
    Console.Error.WriteLine("USAGE: myhead <filename>");
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

listOfLines.Reverse();

List<string> lastLines = new List<string>();

for (var i = 0; i < LINE_COUNT; i++)
{
    lastLines.Add(listOfLines[i]);
}

lastLines.Reverse();

foreach (string line in lastLines)
{
    Console.WriteLine(line);
}