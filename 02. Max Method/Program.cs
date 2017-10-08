using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(number1, number2, number3));
        }

        static int GetMax(int a, int b, int c)
        {
            int biggerNumber = Math.Max(a, b);
            int biggestNumber = Math.Max(biggerNumber, c);

            return biggestNumber;

        }
    }
}
