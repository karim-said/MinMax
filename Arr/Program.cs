using System;
using System.Runtime.InteropServices;
 //MinMax7==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            double p_max, l_min, now;
            int N, i_max = 1, i_min = 1;

            Console.Write("You need enter a value for N variable ");

            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("now = ");
            now = double.Parse(Console.ReadLine());
            p_max = now;
            l_min = now;

            for (int i = 1; i < N; i++)
            {
                Console.Write("now = ");
                now = double.Parse(Console.ReadLine());

                if (now > p_max)
                {
                    i_max = i + 1;
                    p_max = now;
                }

                if (now <= l_min)
                {
                    i_min = i + 1;
                    l_min = now;
                }
            }

            Console.WriteLine($"i_max = {i_max}\ni_min = {i_min}\n");
            Console.ReadKey();
        }
    }
}
