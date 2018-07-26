using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal height = 1.88M; // storing a double value in an object
            dynamic name = "Amir"; // storing a string value in an object
            int length1 = name.Length; // gives compile error!
            int length2 = ((string)name).Length; // cast to access members
            var b = 1;
        }
    }
}
