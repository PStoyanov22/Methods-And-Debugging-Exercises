using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Podouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(GetCenterPoint(x1, y1, x2, y2));
        }

        static string GetCenterPoint(double x1, double y1, double x2, double y2)
        {
            double hipotenuseOne = (double)Math.Sqrt(x1 * x1 + y1 * y1);

            double hipotenuseTwo = (double)Math.Sqrt(x2 * x2 + y2 * y2);
            string closerPoint = "";
            if (hipotenuseOne > hipotenuseTwo)
            {
                closerPoint = $"({x2}, {y2})";
                
            }
            else if (hipotenuseOne <= hipotenuseTwo)
            {
                closerPoint = $"({x1}, {y1})";
                
            }
            return closerPoint;
            
        }
    }
}
