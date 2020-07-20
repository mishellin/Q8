using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c; 
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double res = Func.find_square_triangle(a, b, c);
            Console.WriteLine(res);
            Console.ReadLine();


        }
    }
}
