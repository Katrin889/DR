using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("dyljina b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("jelan simvol");
            var c = Console.ReadLine();
            if (b >= 3 && b <= 13)
            {
                for (int i = 0; i < b; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                for (int r = 0; r < a - 2; r++)
                {
                    Console.Write('*');
                    for (int w = 0; w < b - 2; w++)
                        Console.Write(c);
                    Console.Write('*');
                    Console.WriteLine();
                }
                for (int i = 0; i < b; i++)
                {
                    Console.Write('*');
                }
            }
            else Console.WriteLine("Try again");
        }
    }
}
