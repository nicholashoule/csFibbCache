using System;
using System.Collections.Generic;

namespace csFibbCache
{
    class Program
    {
        private const decimal V = 0;
        private const decimal I = 1;
        private const decimal II = 2;

        // Int, Max: 2147483647
        // Fibb 46: 1836311903
        // Fibb 47: 2971215073

        // long, Max: 9223372036854775807
        // Fibb 92: 7540113804746346429
        // Fibb 93: -6246583658587674878

        // decimal, Max: 79228162514264337593543950335
        // Fibb 139: 50095301248058391139327916261
        // Fibb 140: ~(79228162514264337593543950335)
        private const int fValue = 139;

        // Create a cache
        private static Dictionary<decimal, decimal> decimalCache = new Dictionary<decimal, decimal>();

        // Main ... program control driver
        public static void Main(string[] args)
        {
            Console.WriteLine("Running Fibb()");
            for (decimal i = V; i <= fValue; i++)
            {
                Console.WriteLine("Fibb {0}: {1}", i, Fibb(i));
            }

            Console.WriteLine("Final Fibb {0}: {1}", fValue, Fibb(fValue));
        }

        // Fibb ... given an index return fibonacci value
        public static decimal Fibb(decimal n)
        {
            decimal result;

            // Check the cache for n
            if (decimalCache.ContainsKey(n)) { return decimalCache[n]; }

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
                        return decimal.MaxValue;
                    }
            }

            decimalCache.Add(n, result);
            return result;
        }
    }
}
