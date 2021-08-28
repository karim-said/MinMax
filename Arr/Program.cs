using System;
using System.Runtime.InteropServices;
 //MinMax16 ==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int min=0,count=0, now;
            bool flag=true;

            int N;

            Console.Write("You need enter a value for N variable ");
            N = Convert.ToInt32(Console.ReadLine());

                       

            for (int i = 1; i <= N; i++)
            {
                          
                Console.Write("now = ");
                now = Convert.ToInt32(Console.ReadLine());

                if (flag)
                {
                    min = now;                    
                    flag = false;
                }


                if (now < min)
                {
                    min = now;
                    count = 0;
                }
                count++;
                                
            }

            Console.WriteLine("count -> " + Convert.ToInt32(N - count) );
            Console.ReadKey();
        }
    }
}
