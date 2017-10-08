using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Instruction_Set
{
    class Program
    {
        static void Main()
        {
            string instruction = Console.ReadLine().ToUpper();


            long result = 0;
            while (instruction != "END")
            {
                

                string[] input = instruction.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

               
                switch (input[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(input[1]);
                            result = operandOne + 1;                            
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(input[1]);
                            result = operandOne - 1;                            
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(input[1]);
                            long operandTwo = long.Parse(input[2]);
                            result = operandOne + operandTwo;                            
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(input[1]);
                            long operandTwo = long.Parse(input[2]);
                            result = (long)(operandOne * operandTwo);                            
                            break; 
                        }
                }

                Console.WriteLine(result);
                instruction = Console.ReadLine();

               
            }
            
        }
    }
}
