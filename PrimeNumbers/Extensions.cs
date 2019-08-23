using System;

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
    }
}