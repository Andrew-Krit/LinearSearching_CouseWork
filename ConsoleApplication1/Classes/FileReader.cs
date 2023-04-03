using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1.Classes
{
    public static class FileReader
    {
        public static int[] ReadElementsFromFile(string filePath)
        {
            var streamReader = new StreamReader(filePath);

            var text = streamReader.ReadToEnd();

            var objectArray = text.Split(' ');
            
            return Array.ConvertAll(objectArray, str => int.Parse(str));;
        }
    }

}