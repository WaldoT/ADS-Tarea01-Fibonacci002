using System;
using System.Collections.Generic;

namespace BigONotationPartial
{
    class Logarithmic
    {
        static void Main(string[] args)
        {
            Logarithmic logarithmic = new Logarithmic();
            LogarithmicExampleType quadraticExampleType = LogarithmicExampleType.BinarySearch;
            switch (quadraticExampleType)
            {
                case LogarithmicExampleType.BinarySearch:
                    List<int> numberList = new List<int>() { 1, 3, 3, 7, 10, 11, 16, 17, 20, 21, 25, 26, 30, 32, 34 , 35 };
                    int needle = 26;
                    int min = 0;
                    int? position = logarithmic.BinarySearch(numberList, needle, min, numberList.Count - 1);
                    position = position ?? -1;
                    Console.WriteLine("Position: {0}", position);
                    break;
            }
            Console.ReadLine();
        }

        /// Complexity: O(log2 N)
        internal int? BinarySearch(List<int> numberList, int needle, int min, int max)
        {
            var midpoint = (max + min) / 2;
            if (numberList.Count > 0 && numberList[midpoint] == needle)
            {
                return midpoint;
            }
            if (min >= max)
            {
                return null;
            }
            if (numberList[midpoint] > needle)
            {
                return BinarySearch(numberList, needle, min, midpoint - 1);
            }
            return BinarySearch(numberList, needle, midpoint + 1, max);
        }
    }
}
