using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace RiderCopyBug;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.txt")));
    }
}