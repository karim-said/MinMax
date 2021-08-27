using System;
using System.Runtime.InteropServices;
 //MinMax15 ==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            double max=0,i_=0, now,B,C;
            bool flag=true;

         

            Console.Write("You need enter a value for B variable ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.Write("You need enter a value for C variable ");
            C = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                          
                Console.Write("now = ");
                now = Convert.ToDouble(Console.ReadLine());
                if(now>B && now < C && flag)
                {
                    max = now;
                    i_ = i;
                    flag = false;
                }    
                if(now > B && now < C && now > max)
                {
                    max = now;
                    i_ = i;
                }
                                
            }

            Console.WriteLine("max -> " + max + "            " + "i_ -> " + i_);
            Console.ReadKey();
        }
    }
}
