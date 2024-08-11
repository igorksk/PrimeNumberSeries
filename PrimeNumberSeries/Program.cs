using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumberSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("{0} first prime numbers", n);
            
            var primeNumbers = CreatePrimeNumbersSequence(n);

            if (primeNumbers.Count != 0)
            {
                foreach (var number in primeNumbers)
                {
                    Console.Write(number);
                    if (number != primeNumbers.Last())
                    {
                        Console.Write(", ");
                    }
                }
            }

            Console.ReadLine();
        }

        public static List<uint> CreatePrimeNumbersSequence(uint n)
        {
            var primeNumbers = new List<uint>();

            var count = 0u;
            var i = 0u;
            while (count < n)
            {
                if (IsPrimeNumber(i))
                {
                    primeNumbers.Add(i);
                    count++;
                }
                i++;
            }

            return primeNumbers;
        }

        public static bool IsPrimeNumber(uint n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
