using System;
using System.Linq;
using ConsoleApplication1.Classes;

namespace ConsoleApplication1
{
    internal static class Program
    {
        private const string FilePath = "Array.txt";
        
        public static void Main(string[] args)
        {
            string[] array = FileReader.ReadElementsFromFile(FilePath).ToArray();

            Console.WriteLine(string.CompareOrdinal("e","a"));

            var a = Array.ConvertAll(array, e => int.Parse(e));
            
            ShowArrayElements(a);
            a = LinearSearching(a);
            ShowArrayElements(a);
        }

        private static void ShowArrayElements(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
        
        private static int[] LinearSearching(int[] array)
        {
            var elements = array.ToArray();

            for (var i = 0; i < elements.Length; i++)
            {
                for (var j = 0; j < elements.Length - 1; j++)
                {
                    if (elements[j] > elements[j + 1])
                    {
                        var savedElement = elements[j + 1];
                        elements[j + 1] = elements[j];
                        elements[j] = savedElement;
                    }
                }
            }

            return elements;
        }
    }
}