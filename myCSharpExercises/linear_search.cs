using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class linear_search
    {
        public void Run()
        {
            int n;
            Console.Write("The number of elements of the array: ");
            while (int.TryParse(Console.ReadLine(), out n) == false)
                Console.WriteLine("Try again with an integer");
            int[] arr = new int[n];
            for(int i=0; i < n; i++)
            {
                Console.Write("Enter the elements");
                while (int.TryParse(Console.ReadLine(), out arr[i]) == false)
                    Console.WriteLine("Try again with an integer");
            }
            int x=0;
            Console.Write("Element to Search: ");
            while (int.TryParse(Console.ReadLine(), out x) == false)
                Console.WriteLine("Try again with an integer");
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    index=i;
            }
            if (index != 0)
                Console.WriteLine("Found" + index);
            else
                Console.WriteLine("Not Found");
        }
    }
}
