using System;
using System.Runtime.InteropServices;
 //MinMax9==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int f_max, l_max, now;
            int N, f_i = 1, l_i = 1;

            Console.Write("You need enter a value for N variable ");

            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("now = ");
            now = Convert.ToInt32(Console.ReadLine());
            f_max = now;
            l_max = now;

            for (int i = 1; i < N; i++)
            {
                Console.Write("now = ");
                now = Convert.ToInt32(Console.ReadLine());

                if (now > f_max)
                {
                    f_i = i + 1;
                    f_max = now;
                }

                if (now >= l_max)
                {
                    l_i = i + 1;
                    l_max = now;
                }
            }

            Console.WriteLine($"f_i = {f_i}\nl_i = {l_i}\n");
            Console.ReadKey();
        }
    }
}
