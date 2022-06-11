using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacje
{
    class Delegaty
    {
        public int max(int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            int[] arr = new int[] { arg1, arg2, arg3, arg4, arg5 };
            int max = arr.Max();
            return max;
        }
        public int min(int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            int[] arr = new int[] { arg1, arg2, arg3, arg4, arg5 };
            int min = arr.Min();
            return min;
        }
        public int avg(int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            int[] arr = new int[] { arg1, arg2, arg3, arg4, arg5 };
            int avg = arr.Sum()/5;
            return avg;
        }
        public int median(int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            int[] arr = new int[] { arg1, arg2, arg3, arg4, arg5 };
            Array.Sort(arr);
            if(arr.Length % 2 == 0)
            {
                return (arr[arr.Length / 2 - 1] + arr[arr.Length / 2]) / 2;
            } 
            else
            {
                return arr[(arr.Length - 1) / 2];
            }
        }
    }
}
