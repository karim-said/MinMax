using System;
using System.Runtime.InteropServices;
 //MinMax3==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, S_max = 0;
            int N;

            Console.Write("You need enter a value for N variable ");

            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            S_max = 2 * (a + b);
            for (int i = 0; i < N - 1; i++)
            {
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                if (2 * (a + b) > S_max) S_max = 2 * (a + b);
            }

            Console.WriteLine($"S_max = {S_max}\n");

            Console.ReadKey();

        }
    }
}
