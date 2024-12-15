using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("na koe da razdelq? ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("na koe da ne se deli? ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("kolko chisla shte wywejdate");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % a == 0 && num % b != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
