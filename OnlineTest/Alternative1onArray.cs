using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTest
{
    public class Alternative1onArray
    {

        public void PrintArray(int[] array, int k)
        {
            //
            List<int> lst_res = new List<int>(); //A List of Interger value for result
            int counter = 0, currentvalue = 0; //counter and currentvalue
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 1)
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }
                lst_res.Add(array[i]);
                if (counter == 2)
                {
                    lst_res.Add(currentvalue);
                    if (currentvalue == 0)
                        currentvalue = 1;
                    else
                        currentvalue = 0;
                    counter = 0;
                }
            }

            foreach (int i in lst_res) {
                Console.Write(i);
            }
        }
    }
}
