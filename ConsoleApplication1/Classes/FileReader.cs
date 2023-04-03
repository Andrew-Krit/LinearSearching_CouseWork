using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1.Classes
{
    public static class FileReader
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