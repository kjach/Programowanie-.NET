using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_metody_abstrakcyjne
{
    abstract class First
    {
        public abstract void f(int n);
        public virtual void r(string s1)
        {
            string s2 = "";
            int count = 1;
            s1 += " ";
            for (int i = 0; i < s1.Length - 1; i++)
            {
                if (s1[i] == s1[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count == 1)
                    {
                        s2 += s1[i];
                    }
                    else
                    {
                        s2 += count;
                        s2 += s1[i];
                    }
                    count = 1;
                }
            }
            Console.WriteLine("Compressed word: " + s2);
        }
    }
}
