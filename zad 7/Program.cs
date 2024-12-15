using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            var n = int.Parse(Console.ReadLine());
            var p = true;
            for (var i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                {
                    p = false;
                    break;
                }
            if (p) Console.WriteLine("Простоp");
            else Console.WriteLine("Сложноs");
        }
    }
}
