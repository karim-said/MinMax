using System;
using System.Runtime.InteropServices;
 //MinMax1==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int _min = 0, _max = 0, N, _NOW;

            Console.Write("You need enter a value for N variable ");

            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("Now - ");
                _NOW = Convert.ToInt32(Console.ReadLine());
                if (_NOW < _min) _min = _NOW;
                if (_NOW > _max) _max = _NOW;
            }

            Console.WriteLine($"Min = {_min}\nMax = {_max}");
            Console.ReadKey();

        }
    }
}
