using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class lucky_number
    {
        static bool isLucky(int n)
        {
            // This array is used to check if a digit is already seen or not..
            bool[] arr = new bool[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = false;
            }

            while (n > 0)
            {
                int digit = n % 10;

                //if digit is already seen return false                
                if (arr[digit])
                    return false;
                arr[digit] = true;//Mark this digit as seen
                n = n / 10;
            }
            return true;
        }
        public void Run()
        {
            int[] arr = { 1291, 897, 4566, 1232, 80, 700 };
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                if (isLucky(arr[i]))
                    Console.Write(arr[i] + " is Lucky");
                else
                    Console.Write(arr[i] + " is not Lucky");
            }
        }
    }
}
