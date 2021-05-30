using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonim_Function
{

    //static class Extentions
    //{
    //    public static int CountOfWord(char number)
    //    {
    //        if (string.IsNullOrEmpty(number))
    //        {
    //            return 0;
    //        }
    //        return data.Split(' ').Length;
    //    }

    //}

    static class Extetions
    {
        public static bool Check(string s)
        {
            int i;
            for (i = 0; i < s.Length; i++)
            {
                string str = s;
                char ch = s[i];
                int freq = str.Count(f => (f == ch));

                if (freq == 3)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckPhoneNumber(string s)
        {
            int i;
            for (i = 0; i < s.Length; i++)
            {
                string str = s;
                char ch = s[i];
                int freq=0;
                if (ch != '-')
                {
                    freq = str.Count(f => (f == ch));
                }

                if (freq >= 2)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool Smile(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]=='s'&& s[i] == 'm'&& s[i] == 'i'&& s[i] == 'l'&& s[i] == 'e')
                {
                    return true;
                }
            }
            return false;
        }

    }

}
