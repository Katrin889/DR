using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("wyweddete simvol ");
            var b = Console.ReadLine();
            for (int r = 1; r <= n; r++)
            {
                Console.Write(b);
                for (int j = 1; j < r; j++)
                    Console.Write(b);
                Console.WriteLine();
            }
        }
    }
}
