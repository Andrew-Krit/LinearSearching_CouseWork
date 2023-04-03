using System;
using System.Data.SqlTypes;
using System.Linq;
using ConsoleApplication1.Classes;

namespace ConsoleApplication1
{
    internal static class Program
    {
        private const string FilePath = "Array.txt";
        
        public static void Main(string[] args)
        {
            var array = FileReader.ReadElementsFromFile(FilePath).ToArray();

            ShowArrayElements(array);
            var valueToSearch = int.Parse(Console.ReadLine());
            var searchedIndex = LinearSearch(array, valueToSearch);
            Console.WriteLine(searchedIndex);

            var orderedArray = array;
            Array.Sort(orderedArray);
            
            ShowArrayElements(orderedArray);
            valueToSearch = int.Parse(Console.ReadLine());
            searchedIndex = BinarySearch(orderedArray, valueToSearch, 0, array.Length - 1);
            Console.WriteLine(searchedIndex);
        }

        private static void ShowArrayElements(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
        
        private static int LinearSearch(int[] array, int valueToSearch)
        {
            if (array == null && array.Length == 0)
                throw new Exception("Нечего искать, массив пустой или в нём нет значений.");
                
            for (var i = 0; i < array.Length; i++)
                if (array[i] == valueToSearch)
                    return i;

            return -1;
        }
        
        private static int BinarySearch(int[] array, int valueToSearch, int firstIndex, int lastIndex)
        {
            var middleIndex = (firstIndex + lastIndex) / 2;
        
            if (firstIndex > lastIndex)
                return -1;
            
            var middleValue = array[middleIndex];

            Console.WriteLine($"{firstIndex} {lastIndex} {middleValue}");
            
            if (middleValue == valueToSearch)
                return middleIndex;
            
            if (valueToSearch < middleValue)
                return BinarySearch(array, valueToSearch, firstIndex, middleIndex - 1);
            
            return BinarySearch(array, valueToSearch, middleIndex + 1, lastIndex);

        }
    }
}