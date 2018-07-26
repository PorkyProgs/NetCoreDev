using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace PrimeFactors
{

    class Program
    {

        public IEnumerable<int> GetFactors(int input)
        {
            int first = Primes()
                .TakeWhile(x => x <= Math.Sqrt(input))
                .FirstOrDefault(x => input % x == 0);
            return first == 0
                    ? new[] { input }
                    : new[] { first }.Concat(GetFactors(input / first));
        }

        public void GetPrimeFactors()
        {
            var factors = GetFactors(825);
            factors.ToList().ForEach(Console.WriteLine);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number you want to find the prime factors for:");
            int number = Console.ReadLine();
        }
    }
}
