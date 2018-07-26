using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal c = 0.1M; // M indicates a decimal literal value
            decimal d = 0.2M;
            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            }
        }
    }
}
