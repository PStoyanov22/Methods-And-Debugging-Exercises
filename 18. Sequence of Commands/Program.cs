using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Sequence_of_Commands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';


        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            uint[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(uint.Parse)
                .ToArray();

            string command = "";

           

            while (!command.Equals("stop"))
            {
                command = Console.ReadLine();
                int[] args = new int[2];

                if (command.Equals("add") ||
                    command.Equals("substract") ||
                    command.Equals("multiply"))
                {
                    string[] stringParams = command.Split(ArgumentsDelimiter);
                    args[0] = int.Parse(stringParams[0]);
                    args[1] = int.Parse(stringParams[1]);

                    PerformAction(array, command, args);
                }

                PerformAction(array, command, args);

                PrintArray(array);
                Console.WriteLine('\n');

                command = Console.ReadLine();
            }
        }

        static void PerformAction(uint[] arr, string action, uint[] args)
        {
            uint[] array = arr.Clone() as uint[];
            uint pos = args[0];
            uint value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos+1] *= value;
                    break;
                case "add":
                    array[pos+1] += value;
                    break;
                case "subtract":
                    array[pos+1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(uint[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = array[i - 1];
            }
        }

        private static void ArrayShiftLeft(uint[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
        }

        private static void PrintArray(uint[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
