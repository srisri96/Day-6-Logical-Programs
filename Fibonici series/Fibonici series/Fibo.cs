using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonici_series
{
    internal class Fibo
    {
        public static void Fibo1()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a1 = 0, a2 = 1, a3 = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(a1);
                }
                if (i == 1)
                {
                    Console.WriteLine(a2);
                }
                a3 = a1 + a2;
                a1 = a2;
                a2 = a3;
                Console.WriteLine(a3);
            }
        }
    }
}
