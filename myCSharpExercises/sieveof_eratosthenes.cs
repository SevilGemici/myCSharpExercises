using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class sieveof_eratosthenes
    {
        public static void SieveofEratosthenes(int n)
        {
            bool[] prime = new bool[n + 1];
            for (int i = 0; i < n; i++)
                prime[i] = true;
            for(int i=2; i*i<=n; i++)
            {
                if (prime[i] == true)
                {
                    for (int j = i * i; j <= n; j = j + i)
                        prime[j] = false;
                }
            }
            for(int i = 2; i < n; i++)
            {
                if (prime[i] == true)
                    Console.Write(i + " ");
            }

        }

        public void Run()
        {
            int n = 30;
            SieveofEratosthenes(n);
        }
    }
}
