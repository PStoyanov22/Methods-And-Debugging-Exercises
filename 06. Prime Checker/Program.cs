using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(isPrime(number));
        }

        static bool isPrime(long number)
        {
            if (number == 0 || number == 1 )
            {
                return false;
            }                      

            for (int i = 2; i <= Math.Abs(Math.Sqrt(number)); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;



        }
    }
}
