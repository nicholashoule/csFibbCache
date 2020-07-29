using System;
using System.Collections.Generic;

namespace csFibbCache
{
    class Program
    {
        private const int V = 0;
        private const int I = 1;
        private const int II = 2;
        private const int fValue = 42;

        // Create a cache
        private static Dictionary<int, int> intCache = new Dictionary<int, int>();

        // Main ... program control driver
        public static void Main(string[] args)
        {
            Console.WriteLine("Running Fibb()");
            for (int i = V; i <= fValue; i++)
            {
                Console.WriteLine("Fibb {0}: {1}", i, Fibb(i));
            }

            // 42
            Console.WriteLine("Final Fibb {0}: {1}", fValue, Fibb(fValue));
        }

        // Fibb ... given an index return fibbonacci value
        public static int Fibb(int n)
        {
            int result;

            // Check the cache for n
            if (intCache.ContainsKey(n))
            {
                return intCache[n];
            }

            switch (n)
            {
                case V:
                    result = V;
                    break;
                case I:
                    result = I;
                    break;
                default:
                    result = Fibb(n - I) + Fibb(n - II);
                    break;
            }


            intCache.Add(n, result);
            return result;

        }
    }
}
