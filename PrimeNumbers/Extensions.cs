using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    public static class Extensions
    {
        public static bool isPrime(this int input)
        {
            if(input == 1)
            {
                return false;
            }
            for (int i = 2; i*i <= input; i++)
            {
                if (input % i == 0)
                { 
                    return false;
                }
            }
            return true;
        }

        public static void isPrimeSieveOfEratosthenes(this int input)
        {

            int maximum = input;
            List<bool> sieve = new List<bool>();
            
            for ( int i = 0; i < maximum; i++ ) {
                sieve.Add(true);
            }

            for ( int i = 2; i < sieve.Count-1; i++ ) {
                for ( int j = i-1; j < (sieve.Count-1) / i; j++ ) {
                    int c = i+(i*j);
                    sieve[c] = false;
                }
            }

            for ( int i = 2; i < sieve.Count; i++ ) {
                if ( sieve[i] ) {
                    Console.Write("{0}, ", i);
                }
            }
        }
    }
}