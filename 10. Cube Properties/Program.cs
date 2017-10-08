using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string typeOfParameter = Console.ReadLine().ToLower();

            if (typeOfParameter == "face")
            {
                GetFaceDiagonal(side);
            }

            else if (typeOfParameter == "space")
            {
                GetSpaceDiagonal(side);
            }

            else if (typeOfParameter == "volume")
            {
                GetSquareVolume(side);
            }

            if (typeOfParameter == "area")
            {
                GetSurfaceArea(side);
            }


        }


        static double GetFaceDiagonal(double number)
        {
            double faceDiagonal = Math.Sqrt(2 * (number * number));            
            Console.WriteLine($"{faceDiagonal:f2}");

            return faceDiagonal;
        }

        static double GetSpaceDiagonal(double number)
        {
            double spaceDiagonal = Math.Sqrt((Math.Pow(number, 2)) * 3);
            Console.WriteLine($"{spaceDiagonal:f2}");

            return spaceDiagonal;
        }

        static double GetSquareVolume(double number)
        {
            double volume = Math.Pow(number, 3);
            Console.WriteLine($"{volume:f2}");

            return volume;
        }

        static double GetSurfaceArea(double number)
        {
            double surfaceArea = (Math.Pow(number, 2)) * 6;
            Console.WriteLine($"{surfaceArea:f2}");

            return surfaceArea;
        }
    }
}
