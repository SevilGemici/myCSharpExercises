using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class catalan_number
    {
        static int catalan(int n)
        {
            int res = 0;
            if (n <= 1)
                return 1;
            for(int i = 0; i < n; i++)
            {
                res = res + catalan(i) * catalan(n - i - 1);
            }

            return res;
        }

        public void Run()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(catalan(i) + " ");
            }
        }
    }
}
