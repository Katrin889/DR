using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            while (n <= 25) 
            {
                if (n % 2 == 0) { Console.WriteLine("  " + n); }
                if (n % 2 == 1) { Console.WriteLine(n); }
                n++;
            }
        }
    }
}
