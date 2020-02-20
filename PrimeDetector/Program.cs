using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //List<int> intList = new List<int>() { 3, 1, 5, 7, 5, 9, 4 };
            List<int> intList = new List<int>() { 1, 2, 3, 3, 3, 7, 8 };

            int[] outputInt = Tools.FindPrimeSmallerThan(intList, 6);

            //Console.WriteLine("{0} is prime: {1}", testNum, isPrime);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
