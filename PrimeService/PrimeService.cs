using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool newMethod(int candidate)
        {
            int newVar = 1;
            int otherVar = 2;
            int mathVar = newVar * otherVar;
            return true;
        }
    }
}
