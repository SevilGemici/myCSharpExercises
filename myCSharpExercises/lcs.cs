using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class lcs
    {
        static int lcsfind(char[] X,char[] Y,int m,int n)
        {
            if (m == 0 || n == 0)
                return 0;
            if (X[m - 1] == Y[n - 1])
                return 1 + lcsfind(X, Y, m - 1, n - 1);
            else
                return max(lcsfind(X, Y, m, n - 1), lcsfind(X, Y, m - 1, n));
        }
        static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        public void Run()
        {
            String s1 = "AGGTAB";
            String s2 = "GXTXAYB";

            char[] X = s1.ToCharArray();
            char[] Y = s2.ToCharArray();
            int m = s1.Length;
            int n = s2.Length;

            Console.WriteLine("Length of LCS is" + " " + lcsfind(X, Y, m, n));
        }
    }
}
