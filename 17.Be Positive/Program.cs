using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Be_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            long countSequences = long.Parse(Console.ReadLine());

            for (long i = 0; i < countSequences; i++)
            {
                


            long[] input = Console.ReadLine()
                    .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => long.Parse(item))
                    .ToArray();

                long result = 0;

                bool isFound = false;

                for (long j = 0; j < input.Length-1; j++)
                {
                    if (input[j] >= 0)
                    {
                        if (isFound)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(input[j]);                        

                        isFound = true;                        
                    }

                    else 
                    if (input[j] < 0)
                    {
                        result = input[j] + input[j + 1];

                        if (result < 0)
                        {
                            j++;
                            
                        }
                        else if(result >= 0)
                        {
                            if (isFound)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(result);

                            isFound = true;
                            j++;
                          
                        }                       

                    }                   
                }

                if (!isFound)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                }
                

               // bool found = false;
               //
               // for (long j = 0; j < numbers.Count; j++)
               // {
               //     long currentNum = numbers[j];
               //
               //     if (currentNum > 0)
               //     {
               //         if (found)
               //         {
               //             Console.Write(" ");
               //         }
               //
               //         Console.Write(currentNum);
               //
               //         found = true;
               //     }
               //     else
               //     {
               //         currentNum += numbers[j + 1];
               //
               //         if (currentNum > 0)
               //         {
               //             if (found)
               //             {
               //                 Console.Write(" ");
               //             }
               //
               //             Console.Write(currentNum);
               //
               //             found = true;
               //         }
               //     }
               // }
               //
               // if (!found)
               // {
               //     Console.WriteLine("(empty)");
               // }
            }
        }
    }
}
