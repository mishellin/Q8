using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public static class Func
    {
        public static double find_square_circle(double rad)
        {
            if (rad <= 0)
            {
                Console.WriteLine("please retry with correct radius");
                return 0;
            }
            else
            {
                return rad * rad * 333 / 106;
            }
        }
        public static double find_square_triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("please retry with correct lengths");
                return 0;
            }
            else if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("triangle does not exist");
                return 0;
            }
            else
            {
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    Console.WriteLine("congrats! your triangle is rectangular!!!");
                }
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
    }
        
}
