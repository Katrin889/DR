using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Спора на числата е "+(a + b));
            while (b != 0)
            {
                var B = b;
                b = a % b;
                a = B;
            }
            Console.WriteLine("НОД = " + a);
            
        }
    }
}
