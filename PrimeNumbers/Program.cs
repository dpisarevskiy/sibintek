using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
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
            stopwatch.Stop();

            Console.WriteLine($"Time {stopwatch.Elapsed}");
            
            Console.WriteLine("Prime Sieve Of Eratosthenes method");

            stopwatch.Reset();

            stopwatch.Start();
            1000.isPrimeSieveOfEratosthenes();

            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"Time {stopwatch.Elapsed}");

            Console.ReadKey();
        }
    }
}
