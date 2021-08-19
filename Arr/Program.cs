using System;
using System.Runtime.InteropServices;
 //MinMax5==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, v, P_max = 0;
            int N, _i;

            Console.Write("You need enter a value for N variable ");

            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            m = double.Parse(Console.ReadLine());
            Console.Write("v = ");
            v = double.Parse(Console.ReadLine());
            P_max = m / v;
            _i = 1;

            for (int i = 1; i < N; i++)
            {
                Console.Write("m = ");
                m = double.Parse(Console.ReadLine());
                Console.Write("v = ");
                v = double.Parse(Console.ReadLine());
                if (m / v > P_max)
                {
                    P_max = m / v;
                    _i = i + 1;

                }
            }
            Console.WriteLine($"Num {_i}     P_max = {P_max}\n");
            Console.ReadKey();

        }
    }
}
