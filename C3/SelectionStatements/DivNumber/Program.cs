using System;
using static System.Console;

namespace DivNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Byte FirstNumber, SecondNumber;
            Double Result;
            WriteLine("Please enter a number to divide between 0 & 255");
            byte FirstNumber = Convert.ToByte(ReadLine());
            WriteLine("Enter a number to divide the previous entry");
            byte SecondNumber = Convert.ToByte(ReadLine());
            if (FirstNumber != null || SecondNumber != null)
            {
                try
                {
                    Result = FirstNumber / SecondNumber;
                    WriteLine($"Dividing {FirstNumber} by {SecondNumber} results in {Result}");
                }
                catch (Exception ex) { WriteLine($"{ex.GetType()} says {ex.Message}"); }
                
            }
            else { WriteLine("Ensure that in both cases a number is entered!"); }
        }
    }
}
