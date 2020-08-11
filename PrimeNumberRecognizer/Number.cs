using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumberRecognizer
{
    public static class PrimeNumberRecognizer
    {
        public static bool IsPrime(int value)
        {
            if (value > 1)
            {
                float sqrt = (float)Math.Sqrt(value);
                for (int i = 2; i <= sqrt; i++)
                {
                    if (value % i == 0)
                        return false;
                }
                return true;
            }
            else
                return false;
        }
    }
}
