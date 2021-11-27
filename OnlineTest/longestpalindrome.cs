using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OnlineTest
{
    public class longestpalindrome
    {
        public void LongestPalindrome(string str)
        {
            Dictionary<string, int> dct = new Dictionary<string, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (dct.ContainsKey(str[i].ToString()))
                {
                    dct[str[i].ToString()] = dct[str[i].ToString()] + 1;
                }
                else
                {
                    dct.Add(str[i].ToString(), 1);
                }
            }
            int res = dct.GroupBy(x => x.Value).Sum(x => x.Key);
            int rowcount = dct.GroupBy(x => x.Value).Count();
            if (res % 2 == 0 || res % 2 == 1)
            {
                //iterative by 2
                //for (int i = 0; i < rowcount; i++)
                //    dct.ElementAt(0).Value;
            }
        }



    }
}
