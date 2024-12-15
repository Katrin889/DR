using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 1;
            int s = 2;
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            if (n >= 3 && n <= 102)
            {
                while (s <= n)
                {
                    N = N + s;
                    s++;
                }
                Console.WriteLine(N);
            }
        }
    }
}
