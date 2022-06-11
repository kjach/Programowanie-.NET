using System;

namespace Delegacje
{
    class Program
    {
        public delegate int Delegate(int arg1, int arg2, int arg3, int arg4, int arg5);
        static void Main(string[] args)
        {
            
            Delegaty delegat = new Delegaty();

            Delegate del = delegat.max;
            Console.WriteLine(del(10, 12, 94, 1, 213));

            del += delegat.min;
            Console.WriteLine(del(10, 12, 94, 1, 213));

            del += delegat.avg;
            Console.WriteLine(del(10, 12, 94, 1, 213));

            del += delegat.median;
            Console.WriteLine(del(10, 12, 94, 1, 213));
        }
    }
}
