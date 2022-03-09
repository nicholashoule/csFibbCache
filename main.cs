using System;
using System.Collections.Generic;

namespace csFibbCache
{
    class Program
    {
        private const long V = 0;
        private const long I = 1;
        private const long II = 2;

        // Int, Max: 2147483647
        // Fibb 46: 1836311903
        // Fibb 47: 2971215073

        // long, Max: 9223372036854775807
        // Fibb 92: 7540113804746346429
        // Fibb 93: -6246583658587674878

        // decimal, Max: 79228162514264337593543950335
        // Fibb 139: 50095301248058391139327916261
        // Fibb 150: ~(79228162514264337593543950335)
        private const int fValue = 92;

        // Create a cache
        private static Dictionary<long, long> longCache = new Dictionary<long, long>();

        // Main ... program control driver
        public static void Main(string[] args)
        {
            Console.WriteLine("Running Fibb()");
            for (long i = V; i <= fValue; i++)
            {
                Console.WriteLine("Fibb {0}: {1}", i, Fibb(i));
            }

            Console.WriteLine("Final Fibb {0}: {1}", fValue, Fibb(fValue));
        }

        // Fibb ... given an index return fibonacci value
        public static long Fibb(long n)
        {
            long result;

            // Check the cache for n
            if (longCache.ContainsKey(n)) { return longCache[n]; }

            switch (n)
            {
                case V:
                    result = V;
                    break;
                case I:
                    result = I;
                    break;
                default:
                    try
                    {
                        result = Fibb(n - I) + Fibb(n - II);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                        return long.MaxValue;
                    }
            }

            longCache.Add(n, result);
            return result;
        }
    }
}
