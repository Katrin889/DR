using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            double Z = 0;
            while (n > 0)
            {
                int r = n % 2;
                n = n / 2;
                Z = Z + Math.Pow(10, i) * r;
                i++;
            }
            Console.WriteLine(Z);
        }
    }
}
