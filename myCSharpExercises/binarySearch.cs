using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class binarySearch
    {
        static int binaySearching(int[] arr,int l,int r,int x)
        {
            int mid = l + (r - l) / 2;
            if (r >= l)
            {
                if (arr[mid] == x)
                    return mid;
                if (arr[mid] > x)
                    return binaySearching(arr, l, mid - 1, x);
                if (arr[mid] < x)
                    return binaySearching(arr, mid + 1, r, x);
            }
            return -1;

        }

        public void Run()
        {
            Console.Write("Number of Array: ");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[s];
            for(int i = 0; i < s; i++)
            {
                Console.Write("Input a Value:");
                while (int.TryParse(Console.ReadLine(), out arr[i]) == false)
                    Console.WriteLine("Try again with an integer");
            }
            int temp = 0;
            for (int i = 0; i < s-1; i++)
            {
                for(int j = i + 1; j < s; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                
            }
            Console.Write("Searching Number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int result = binaySearching(arr, 0, s - 1, x);
            if (result == -1)
                Console.WriteLine("Not Found!");
            else
                Console.WriteLine("Element Found at Index "+result);

        }
    }
}
