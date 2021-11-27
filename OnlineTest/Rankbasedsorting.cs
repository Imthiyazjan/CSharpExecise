using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineTest
{
    public class Rankbasedsorting
    {
        public void RankbasedSorting(int[,] array)
        {
            Dictionary<int, int> dct = new Dictionary<int, int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                dct.Add(array[i, 0], array[i, 1]);
            }
            var res = dct.OrderBy(x => x.Value).ThenBy(x=>x.Key);
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1) - 1; j++)
            //    {
            //        if (array[i, j] < array[j, j + 1])
            //        {
            //            int temp = array[i, j];
            //            array[i, j] = array[i, j + 1];
            //            array[i, j + 1] = temp;
            //        }
            //    }
            //}
            foreach (KeyValuePair<int, int> i in res) {
                Console.WriteLine("{0} {1}", i.Key, i.Value);
            }
        }
    }
}
