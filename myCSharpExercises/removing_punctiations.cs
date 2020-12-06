using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GeeksForGeeks
{
    class removing_punctiations
    {
        public void Run()
        {
            // input string  
            String str = "Welcome???@@##$ to#$% Geeks%$^for$%^&Geeks";

            // similar to Matcher.replaceAll  
            str = Regex.Replace(str, @"[^\w\d\s]", "");

            Console.Write(str);
        }
    }
}
