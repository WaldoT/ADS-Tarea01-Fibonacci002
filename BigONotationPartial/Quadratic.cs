using System;

namespace BigONotationPartial
{
    class Quadratic
    {
        static void Main(string[] args)
        {
            Quadratic quadratic = new Quadratic();
            QuadraticExampleType quadraticExampleType = QuadraticExampleType.CreateAllPairs;
            switch (quadraticExampleType)
            {
                case QuadraticExampleType.CreateAllPairs:
                    int n = 5;
                    quadratic.CreateAllPairs(n);
                    break;
            }
            Console.ReadLine();
        }

        /// Complexity: O(N^2)
        internal void CreateAllPairs(int n)
        {
            int x = 1;            
            while (x <= n)
            {
                int y = 1;
                while (y <= n)
                {
                    Console.WriteLine("{0}, {1}", x, y);
                    y++;
                }
                x++;
            }
        }
    }
}
