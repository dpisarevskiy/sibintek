using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();
            int numbersLimit = 1000;

            for (int i = 1; i <= numbersLimit; i++)
            {
                if(i.isPrime())
                {
                    primeNumbers.Add(i);
                }
            }

            foreach (var num in primeNumbers)
            {
                Console.Write("{0}, ", num);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{primeNumbers.Count} Prime numbers in the set of 1-{numbersLimit}.");
            Console.ReadKey();

        }
    }
}
