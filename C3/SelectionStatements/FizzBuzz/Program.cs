using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;

            for (int i = 1; i < number; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0)) { Console.WriteLine($"FizzBuzz "); }
                else if(i % 3==0) { Console.Write($"\nFizz "); }
                else if(i % 5 ==0) { Console.Write($"\nBuzz "); }
                else { Console.Write($"{i}, "); }
            }
        }
    }
}

