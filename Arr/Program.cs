using System;
using System.Runtime.InteropServices;
 //MinMax14 ==================================================
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            double min=0,i_=0, now,B;
            bool flag=true;

          

            Console.Write("You need enter a value for B variable ");
            B = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                          
                Console.Write("now = ");
                now = Convert.ToDouble(Console.ReadLine());
                if(now>B && flag)
                {
                    min = now;
                    flag = false;
                }    
                if(now > B && now <= min)
                {
                    min = now;
                    i_ = i;
                }
                                
            }

            Console.WriteLine("min -> " + min + "            " + "i_ -> " + i_);
            Console.ReadKey();
        }
    }
}
