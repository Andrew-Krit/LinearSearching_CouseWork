using System;
using ConsoleApplication1.Classes;

namespace ConsoleApplication1
{
    internal static class Program
    {
        private const string FilePath = "Array.txt";
        
        public static void Main(string[] args)
        {
            var array = FileReader.ReadElementsFromFile(FilePath);

            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}