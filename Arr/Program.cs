using System;
using System.Runtime.InteropServices;
 //MinMax8==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int f_min, l_min, now;
            int N, f_i = 1, l_i = 1;

            Console.Write("You need enter a value for N variable ");

            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("now = ");
            now = Convert.ToInt32(Console.ReadLine());
            f_min = now;
            l_min = now;

            for (int i = 1; i < N; i++)
            {
                Console.Write("now = ");
                now = Convert.ToInt32(Console.ReadLine());

                if (now < f_min)
                {
                    f_i = i + 1;
                    f_min = now;
                }

                if (now <= l_min)
                {
                    l_i = i + 1;
                    l_min = now;
                }
            }

            Console.WriteLine($"f_i = {f_i}\nl_i = {l_i}\n");
            Console.ReadKey();
        }
    }
}
