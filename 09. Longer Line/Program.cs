using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            


            double firstLine = GetLongerLine( x1,  y1,  x2,  y2);

            double secondLine = GetLongerLine( x3,  y3,  x4,  y4);

            if (firstLine >= secondLine)
            {
                Console.WriteLine(GetCloserPoint(x1, y1, x2, y2));
            }
            else if (secondLine > firstLine)
            {
                Console.WriteLine(GetCloserPoint(x3, y3, x4, y4));
            }

        }

        static string GetCloserPoint(double x1, double y1, double x2, double y2)
        {
            double hipotenuseOne = (double)Math.Sqrt(x1 * x1 + y1 * y1);

            double hipotenuseTwo = (double)Math.Sqrt(x2 * x2 + y2 * y2);
            string closerPoint = "";
            if (hipotenuseOne > hipotenuseTwo)
            {
                closerPoint = $"({x2}, {y2})({x1}, {y1})";

            }
            else if (hipotenuseOne <= hipotenuseTwo)
            {
                closerPoint = $"({x1}, {y1})({x2}, {y2})";

            }
            return closerPoint;


        }

        static double GetLongerLine(double x1, double y1, double x2, double y2)
        {

            double TriangleSide = Math.Abs(x1 - x2);
            double SecondTriangleSide = Math.Abs(y1 - y2);

            double hypothenuse = Math.Sqrt(Math.Pow(TriangleSide, 2) + (Math.Pow(SecondTriangleSide, 2)));

            return hypothenuse;
           
        }
    }
}
