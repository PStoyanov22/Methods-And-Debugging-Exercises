using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = GetFactorial(number);
            int zeroCount = GetTrailingZeros(factorial);
            Console.WriteLine(zeroCount);

        }

        static BigInteger GetFactorial(int number)
        {
            BigInteger result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        static int GetTrailingZeros(BigInteger result)
        {
            

            int zeroCount = 0;

            while (result % 10 == 0)
            {
                result /= 10;
                zeroCount++;
            }




            return zeroCount;



        }
    }
}
