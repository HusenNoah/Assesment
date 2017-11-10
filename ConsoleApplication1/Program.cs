using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var getsum = MyCheck();
            Console.WriteLine(getsum);
        }


       public static int MyCheck()
        {
            const int Max = 4000000;
            int sum = 0;
            int a = 1;
            int b = 1;
            while (b < Max)
            {
                a += b;
                b += a;
                if( a%2==0 && a < Max)
                {
                    sum += a;

                }
                else if(b%2==0 && b < Max)
                {
                    sum += b;
                }

               
            }
            return sum;
        }
    }
}
