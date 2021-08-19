using System;
using System.Runtime.InteropServices;
 //MinMax11==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, now;
            int N, imax = 1, imin = 1;

            Console.Write("You need enter a value for N variable ");

            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("now = ");
            now = Convert.ToInt32(Console.ReadLine());
            min = now;
            max = now;

            for (int i = 1; i < N; i++)
            {
                Console.Write("now = ");
                now = Convert.ToInt32(Console.ReadLine());

                if (now <= min)
                {
                    imax = i + 1;
                    min = now;
                }

                if (now >= max)
                {
                    imin = i + 1;
                    max = now;
                }
            }

            Console.WriteLine("ex = {0}\n", imin > imax ? imin : imax);
            Console.ReadKey();
        }
    }
}
