using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            while (n <= 25)
            {
                if (n % 2 == 0) 
                { 
                    Console.Write("         " + n);
                    Console.WriteLine(" " + (n * n));
                }
                if (n % 2 == 1) 
                { 
                    Console.Write(n);
                    Console.WriteLine(" " + (n * n * n));
                }
                n++;
            }
        }
    }
}
