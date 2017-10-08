using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            ContainsEvenDigits(number);
     
        
    
      for (int i = 1; i < number; i++)
      {
          if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigits(i))
          {
              Console.WriteLine(i);
          }
      }
      


        }

        static bool IsPalindrome(int number)
        {
            string num = number.ToString();

            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] == num[num.Length - 1 - i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        static bool SumOfDigits(int num)
        {
            string number = num.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }

            
        }

        static bool ContainsEvenDigits(int num)
        {
            string number = num.ToString();
            for (int i = 0; i < number.Length; i++)
            {
                int rem = int.Parse(number[i].ToString());

                if (rem % 2 == 0)
                {
                    return true;
                    
                }
                else
                {
                    continue;
                }
            }


            return false;
        }
    }
}
