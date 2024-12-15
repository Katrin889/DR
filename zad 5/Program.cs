using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            double n = double.Parse(Console.ReadLine());
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            double x2 = x;
            double y = 1;
            double S = 1;
            double f = 1;
            while (y <= n)
            {
                S = S + (f / x);
                y++;
                x = x * x2;
                f = f * y;
            }
            Console.WriteLine(S);
        }
    }
}
