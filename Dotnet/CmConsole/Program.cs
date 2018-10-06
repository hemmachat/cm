using System;
using CmLibrary;

namespace CmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var retsult = IntegerLibrary.MostCommonNumbers(new int[] {1, 2, 3, 4, 5, 1, 6, 7});
        }
    }
}
