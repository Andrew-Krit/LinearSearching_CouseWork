using System;
using System.Collections.Generic;
using System.IO;

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

        private static class FileReader
        {
            public static IEnumerable<string> ReadElementsFromFile(string filePath)
            {
                var streamReader = new StreamReader(filePath);

                var text = streamReader.ReadToEnd();

                var objectArray = text.Split(' ');
            
                return objectArray;
            }
        }
    }
}