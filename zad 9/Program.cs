using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int N = int.Parse(Console.ReadLine());
            int i = 0;
            while (N > 0)
            {
                N = N / 10;
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
