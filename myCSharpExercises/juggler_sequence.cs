using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class juggler_sequence
    {
        static void printJuggler(int n)
        {
            int a = n;
            Console.Write(a + " ");
            while (a != 1)
            {
                int b = 0;
                if (a % 2 == 0)
                    b = (int)Math.Floor(Math.Sqrt(a));
                else
                    b = (int)Math.Floor(Math.Sqrt(a) * Math.Sqrt(a) * Math.Sqrt(a));
                Console.Write(b + " ");
                a = b;
            }
        }

        public void Run()
        {
            printJuggler(9);
        }
    }
}
