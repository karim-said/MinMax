using System;
using System.Runtime.InteropServices;
 //MinMax13 ==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            double max=0,i_odd=0, now;
            int N;
      
            Console.Write("You need enter a value for N variable ");
            N = Convert.ToInt32(Console.ReadLine());
           
            
            for (int i = 1; i <= N; i++)
            {
                          
                Console.Write("now = ");
                now = Convert.ToDouble(Console.ReadLine());

                if(now % 2 == 1 && now > max)
                {
                    max = now;
                    i_odd = i;
                }
                                
            }

            Console.WriteLine("i_odd -> " + i_odd);
            Console.ReadKey();
        }
    }
}
