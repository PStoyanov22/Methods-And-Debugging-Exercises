using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(FibonnaciNumber(number));

        }

        static int FibonnaciNumber(int num)
        {
            int input = 0;
            int fib = 1;

            for (int i = 0; i < num; i++)
            {
                int temporaryNumber = input;
                input = fib;
                fib = temporaryNumber + input;



            }
            return fib;
        }
    }
}