using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class missing_characters
    {
        static List<char> missingChars(String str, int strLength)
        {
            List<char> charList = new List<char>();
            bool[] mark = new bool[26];
            
            for (int i = 0; i < str.Length; i++)
            {
                if ('A' <= str[i] && str[i] <= 'Z')
                    mark[str[i] - 'A'] = true;
                else if ('a' <= str[i] && str[i] <= 'z')
                    mark[str[i] - 'a'] = true;

            }
            for (int i = 0; i < 26; i++)
            {
                if (mark[i] == false)
                    charList.Add((char)(i+'a'));
            }
            return charList;
        }
        public void Run()
        {
            String str = "The quick brown fox jumps over the dog.";
            List<char> missing = missingChars(str, str.Length);
            if (missing.Count >= 1)
            {
                foreach (var i in missing)
                    Console.Write(i);
            }
        }
    }
}
