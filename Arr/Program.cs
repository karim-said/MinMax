using System;
using System.Runtime.InteropServices;
 //MinMax12==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            double min=0, now;
            int N;
            bool flag = true;
            Console.Write("You need enter a value for N variable ");

            N = Convert.ToInt32(Console.ReadLine());
           
              

            for (int i = 1; i <= N; i++)
            {
                
                
                Console.Write("now = ");
                now = Convert.ToDouble(Console.ReadLine());

                if(now>min && flag)
                {
                    min = now;
                    flag = false;
                }
                if (now < min && now >0) min = now;
                
            }

            Console.WriteLine("min -> " + min);
            Console.ReadKey();
        }
    }
}
