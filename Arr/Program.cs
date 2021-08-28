using System;
using System.Runtime.InteropServices;
 //MinMax17 ==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int max=0,count=0, now;
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
                    max = now;                    
                    flag = false;
                }

                count++;
                if (now >= max)
                {
                    max = now;
                    count = 0;
                }
                                                
            }

            Console.WriteLine("count -> " + count );
            Console.ReadKey();
        }
    }
}
