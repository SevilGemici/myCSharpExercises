using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class arraycopy
    {
        static void myCopy(char[] s1, char[] s2)
        {
            for (int i = 0; i < s1.Length; i++)
                s2[i] = s1[i];

        }
        public void Run()
        {
            String x = "Hello";
            String y = "Hello i am C# Lover";
            char[] s1 = x.ToCharArray();
            char[] s2 = y.ToCharArray();
            myCopy(s1, s2);
            Console.Write(String.Join("",s2));
        }
    }
}
