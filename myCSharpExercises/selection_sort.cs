using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class selection_sort
    {
        static void sort(int[] arr)
        {
            int n = arr.Length;
            for(int i=0; i < n - 1; i++)
            {
                int min_idx = i;
                for(int j = i + i; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                }
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for(int i=0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
        }

        public void Run()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            sort(arr);
            Console.WriteLine("Sorted Array");
            printArray(arr);
        }
    }
}
