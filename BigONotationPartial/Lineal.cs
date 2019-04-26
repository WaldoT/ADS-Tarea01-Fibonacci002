using System;
using System.Collections.Generic;

namespace BigONotationPartial
{
    class Lineal
    {
        static void Main(string[] args)
        {            
            Lineal lineal = new Lineal();
            LinealExampleType linealExampleType = LinealExampleType.Loop;
            switch (linealExampleType)
            {
                case LinealExampleType.Loop:
                    int n = 50;
                    lineal.Loop(n);
                    break;
                case LinealExampleType.ContainsNeedle:
                    List<int> numberList = new List<int>() { 10, 18, 29, 1, 0, 75, 79 };
                    int needle = 76;
                    bool found = lineal.ContainsNeedle(needle, numberList);
                    Console.WriteLine("Number {0} found? {1}", needle, found);
                    break;
                case LinealExampleType.Factorial:
                    int nFactorial = 10;
                    long factorial = lineal.Factorial(nFactorial);
                    Console.WriteLine("Factorial of {0} equal to {1}", nFactorial, factorial);
                    break;
            }
            Console.ReadLine();

            //Probando codigo
        }

        /// Complexity: O(N)
        internal void Loop(long n)
        {
            var counter = 1;
            while (counter <= n)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }

        /// Complexity: O(N)
        internal bool ContainsNeedle(int needle, List<int> numberList)
        {
            foreach (var item in numberList)
            {
                if (item == needle)
                {
                    return true;
                }
            }
            return false;
        }

        /// Complexity: O(N)
        internal long Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
