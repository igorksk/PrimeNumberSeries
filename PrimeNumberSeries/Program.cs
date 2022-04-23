using System;

namespace PrimeNumberSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("{0} first prime numbers", n);
            var count = 0u;
            var i = 0u;
            while (count < n)
            {
                if (IsPrimeNumber(i))
                {
                    Console.Write(i);
                    if (count < n - 1)
                    {
                        Console.Write(", ");
                    }
                    count++;
                }
                i++;
            }

            Console.ReadLine();
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
