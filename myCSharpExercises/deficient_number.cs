using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class deficient_number
    {
        public void Run()
        {
            int num;
            Console.Write("Enter a Number: ");
            while (int.TryParse(Console.ReadLine(), out num) == false)
                Console.WriteLine("Try Again With an Integer");
            int sum = 0;
            for(int i=1; i<=num; i++)
            {
                if (num % i == 0)
                    sum = sum + i;
            }
            if (sum < (2 * num))
                Console.WriteLine("Deficient Number");
            else
                Console.WriteLine("Not a Deficient Number");
        }
    }
}
