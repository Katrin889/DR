using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
                int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
                int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
                int c = int.Parse(Console.ReadLine());
            if (a >= 10 && a <= 100 && b >= 10 && b <= 100 && c >= 10 && c <= 100)
                Console.WriteLine(a + b + c);
            else Console.WriteLine("Try again");
        }
    }
}
