using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTest
{
    public class PrintNorepetants
    {

        public int printNoofrepeats(string str)
        {
            int Max = -1;
            for (int i = 0; i < str.Length; i++) //
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        int temp = j - i - 1;
                        Max = Max > temp ? Max : temp;
                    }
                }
            }
            return Max;
        }
    }
}
