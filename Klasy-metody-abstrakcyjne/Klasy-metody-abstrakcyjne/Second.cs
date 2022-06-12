using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_metody_abstrakcyjne
{
    class Second : First
    {
        public override void f(int x)
        {
            Console.Write("Czynniki pierwsze liczby " + x + " to:");
            int i = 2;
            int e = (int)Math.Sqrt(x);
            while (i <= e)
            {
                while ((x % i) == 0)
                {
                    x /= i;
                    e = (int)Math.Sqrt(x);
                    Console.Write(" " + i);
                }
                i++;
            }
            if (x > 1) Console.Write(" " + x);
        }
    }
}
