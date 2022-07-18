using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupen_numbers
{
    internal class Coupen
    {

        public static int random()
        {
            Random random = new Random();
            int r = random.Next(1, 10);
            return r;
        }

        public static void coup5(int n)
        {
            int[] ar = new int[n];
            for (int i = 0; i < n; i++)             
            {
                ar[i] = random();
                for (int j = 0; j < i; j++)        
                {
                    if (ar[i] == ar[j])            
                    {
                        ar[i] = random();              
                        i--;              
                        break;           
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(ar[i] + "  ");
            }
        }
    }
}
