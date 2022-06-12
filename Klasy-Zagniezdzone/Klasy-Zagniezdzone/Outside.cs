using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_Zagniezdzone
{
    class Outside
    {
        public class Inside
        {
            public double NewtonRaphson(double n)
            {
                double e = 0.000001;
                double x = n / 2;
                while (Math.Abs(x - n / x) > e)
                {
                    x = (x + n / x) / 2;
                    if (x * x == n) return x;
                }
                return x;
            }


        }
        public void result(double n)
        {
            Inside inside = new Inside();
            double result = inside.NewtonRaphson(n);
            Console.WriteLine(result);
        }
    }
}
