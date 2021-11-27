using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTest
{
    public class Printpyramid
    {
        public void PrintPyramid(int n)
        {
            //n=3
            for (int i = 0; i < n; i++) //0 0<3 | 1 1<3
            {
                int currentvalue = 0;//0
                //Here need to print blank spaces
                for (int j = 0; j < n - i - 1; j++) //0 0<3-0-1=>2 | 1 1<3-1-1=>1 2 |
                {
                    Console.Write(" ");
                }
                //print int value
                for (int k = 0; k < (i * 2) + 1; k++) //0 0<0*2+1=>1 | 1 1<1*2+1=>3 |
                {
                    if (k <= i) //0<=0 | 1<=1
                        Console.Write("{0}", ++currentvalue);
                    else
                        Console.Write("{0}", --currentvalue);

                }
                Console.WriteLine();
            }
        }
    }
}
