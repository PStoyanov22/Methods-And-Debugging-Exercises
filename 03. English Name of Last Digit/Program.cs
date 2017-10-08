using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {

        static void Main(string[] args)
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(GetEnglishName(number));
            

        }

        static string GetEnglishName(long number)
        {
            int lastDigit = (int)number % 10;
            string lastDigitName = "";

            switch (number % 10)
            {
                case 0:
                    lastDigitName = "zero";
                    break;

                case 1:
                    lastDigitName = "one";
                    break;

                case 2:
                    lastDigitName = "two";
                    break;


                case 3:
                    lastDigitName = "three";
                    break;

                case 4:
                    lastDigitName = "four";
                    break;

                case 5:
                    lastDigitName = "five";
                    break;

                case 6:
                    lastDigitName = "six";
                    break;

                case 7:
                    lastDigitName = "seven"; 
                    break;

                case 8:
                    lastDigitName = "eight";
                    break;

                case 9:
                    lastDigitName = "nine";
                    break;
                    
            }
            return lastDigitName;

            
        }
    }
}
