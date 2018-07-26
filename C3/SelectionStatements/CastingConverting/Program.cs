using System;
using static System.Console;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 123;
        }
    }
    class One
    {
        public void NotStaicFunc()
        {
            StaticFunc();
        }

        protected void NotStaticProt()
        {
            NotStaticPriv();
        }

        private void NotStaticPriv()
        {

        }

        public static void StaticFunc()
        {

        }
    }

    class Two : One
    {
        public void NotStaticTwo()
        {
            NotStaticProt();
        }
    }
}
