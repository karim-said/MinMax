using System;
using System.Runtime.InteropServices;
 //MinMax6==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            double p_min, l_max, now;
            int N, i_p = 1, i_l = 1;

            Console.Write("You need enter a value for N variable ");

            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("now = ");
            now = double.Parse(Console.ReadLine());
            p_min = now;
            l_max = now;

            for (int i = 1; i < N; i++)
            {
                Console.Write("now = ");
                now = double.Parse(Console.ReadLine());

                if (now < p_min)
                {
                    i_p = i + 1;
                    p_min = now;
                }

                if (now >= l_max)
                {
                    i_l = i + 1;
                    l_max = now;
                }
            }

            Console.WriteLine($"i_p = {i_p}\ni_l = {i_l}\n");
            Console.ReadKey();

        }
    }
}
