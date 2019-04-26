using System;
using System.Diagnostics;

namespace BigONotationPartial
{
    class Exponential
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Exponential exponential = new Exponential();
            ExponentialExampleType exponentialExampleType = ExponentialExampleType.Fibonacci;
            switch (exponentialExampleType)
            {
                case ExponentialExampleType.Fibonacci:
                    int n = 80; //8 40 80

                    //Ejecutar el metodo Fibonacci
                    exponential.Fibonacci(n);

                    break;
            }
            Console.WriteLine("Time elapsed: {0:0.00} seconds", Math.Round(stopWatch.ElapsedMilliseconds / 1000.0, 2));
            Console.ReadLine();
        }

        /// Complexity: O(2^N)
        internal void Fibonacci(long n)
        {
            //Declaramos las nuevas variables
            long a = 0;
            long b = 1;
            long c = 0;

            //Nuevo for
            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Valor {0} = {1}", i, a);
                }
                else
                {
                    c = a;
                    a = b;
                    b = c + a;

                    Console.WriteLine("Valor {0} = {1}", i, a);
                }
            }

            //if (n < 0)
            //{
            //    throw new Exception("n can not be less than zero");
            //}
            //if (n <= 2)
            //{
            //    return 1;
            //}
            //return Fibonacci(n - 1) + Fibonacci(n - 2);

        }
    }
}
