using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class sub_sequence
    {
        static bool isSubSequence(string s1,string s2,int m,int n)
        {
            if (m == 0) //Base Cases
                return true;
            if (n == 0)
                return false;
            if (s1[m - 1] == s2[n - 1])
                return isSubSequence(s1, s2, m - 1, n - 1);
            return isSubSequence(s1, s2, m, n - 1);
        }
        public void Run()
        {
            string s1 = "gksrek";
            string s2 = "geeksforgeeks";
            int m = s1.Length;
            int n = s2.Length;
            bool res = isSubSequence(s1, s2, m, n);
            if (res)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
