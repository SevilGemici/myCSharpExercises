using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class jump_search
    {
        public static int jumpSearch(int[] arr,int x)
        {
            int n = arr.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;

            while(arr[Math.Min(step,n)-1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev > n)
                    return -1;
            }
            while (arr[prev] < x)
            {
                prev++;
                if (prev == Math.Min(step, n))
                    return -1;
            }
            if (arr[prev] == x)
                return prev;
            return -1;
        }

        public void Run()
        {
            int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 12, 21, 34, 55, 89, 144, 233, 377, 610 };
            int x = 55;
            int index = jumpSearch(arr, x);
            Console.Write("Number " + x + " is at index " + index);
        }
    }
}
