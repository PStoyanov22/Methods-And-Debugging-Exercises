using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main()
        {
            string figureType = Console.ReadLine().ToLower();

            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                GetTriangleArea(side, height);


            }
            else if (figureType == "square")
            {
                double squareside = double.Parse(Console.ReadLine());
                GetSquareArea(squareside);

            }


            else if (figureType == "rectangle")
            {
                double rectanglewidth = double.Parse(Console.ReadLine());
                double rectangleheight = double.Parse(Console.ReadLine());

                GetRectangleArea(rectanglewidth, rectangleheight);
            }

            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                GetCircleArea(radius);
            }




        }


        static double GetTriangleArea(double side, double height)
        {
            double area = (side * height) / 2.0;
            Console.WriteLine($"{area:f2}");

            return area;
        }

        static double GetSquareArea(double number)
        {
            double area = number * number;
            Console.WriteLine($"{area:f2}");

            return area;
        }

        static double GetRectangleArea(double width, double height)
        {
            double area = width * height;
            Console.WriteLine($"{area:f2}");

            return area;
        }

        static double GetCircleArea(double number)
        {
            double area = Math.PI * (number * number);
            Console.WriteLine($"{area:f2}");

            return area;
        }

    }
}
