using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Колко числа ще въвеждате ");
            int n = int.Parse(Console.ReadLine());
            var max = -10000000000000;
            var min = 10000000000000;
            for (int i = 0; i < n; i++)
            { 
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                    max = num;
                for (int j = 0; j < num; j++)
                {
                    if (num < min)
                        min = num;
                }
            }
            Console.WriteLine("Най-голямото число е " + max);
            Console.WriteLine("Най-малкото число е " + min);
        }
    }
}
