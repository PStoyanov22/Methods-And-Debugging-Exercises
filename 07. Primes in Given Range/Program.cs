using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());

            List<long> prime = FindPrimesInRange(firstNumber, secondNumber);
            foreach (int item in prime)
            {
                if (item == prime.Last())
                {
                    Console.Write(item);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("{0}, ", item);
                }

                
            }
        }

        static List<long> FindPrimesInRange(long firstNumber, long secondNumber)
        {
            List<long> primes = new List<long>();

            for (long i = firstNumber; i <= secondNumber; i++)
            {
                if( i < 2)
                {

                    continue;
                }

                for (long j = 2; j <= secondNumber; j++)
                {
                    if ( j == i)
                    {
                        primes.Add(i);
                        break;
                    }
                    else if ( i % j == 0)
                    {

                        break;

                    }
                }
            }
            return primes;
        }                   
    }
}
