using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class findInitialsofaName
    {
        static void Initials(string name)
        {
            if (name.Length == 0)
                return;
            Console.Write(Char.ToUpper(name[0]));
            for(int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                    Console.Write(" " + Char.ToUpper(name[i + 1]));
            }
        }
        public void Run()
        {
            string name = "sevil gemici";
            Initials(name);
        }
    }
}
