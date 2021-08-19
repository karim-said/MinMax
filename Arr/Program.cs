using System;
using System.Runtime.InteropServices;
 //MinMax4==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, now;
            int N, _i = 1;

            Console.Write("You need enter a value for N variable ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("a = ");
            now = double.Parse(Console.ReadLine());

            for (int i = 1; i <= N - 1; i++)
            {
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());

                if (a < now)
                {
                    _i = i + 1;
                    now = a;
                }
            }

            Console.WriteLine($"min index num = {_i}\n");
            Console.ReadKey();

        }
    }
}
