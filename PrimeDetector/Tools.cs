using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDetector
{
    internal static class Tools
    {
        internal static bool IsNumberPrime(int num)
        {
            int flooredSquareRoot = Convert.ToInt32(Math.Floor(Math.Sqrt(num)));

            for (int i = 2; i <= flooredSquareRoot; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        internal static int[] FindPrimeSmallerThan(List<int> intList, int maxPrime)
        {
            HashSet<int> relevantPrimes = new HashSet<int>();

            foreach(int i in intList)
            {
                if(i > maxPrime || i < 2)
                {
                    continue;
                }

                if (IsNumberPrime(i))
                {
                    relevantPrimes.Add(i);
                }
            }

            if(relevantPrimes.Count == 0)
            {
                return null;
            } else
            {
                return relevantPrimes.ToArray();
            }
        }
    }
}
