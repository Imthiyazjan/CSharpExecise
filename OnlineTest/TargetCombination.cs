using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineTest
{
    public class TargetCombination
    {
        List<int> result;
        public void TargetValueCombination(int[] array, int target)
        {
            
            //Iteratite the inputs
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    Console.WriteLine("{0} can make {1}", array[i], target);
                }
                else
                {
                    int temp = target - array[i];
                    //for (int j = i; j < array.Length; j++)
                    //{
                    //    if (array[j] == temp)
                    //    {
                    //        Console.WriteLine("{0} can make {1}", array[i], target);
                    //    }
                    //}
                    result = new List<int>();                    
                    recursivemethod(array, i, temp + i);
                }

            }
        }
        public int recursivemethod(int[] array, int i, int target)
        {
            int sum = 0;
            int j = 0;
            for (j= i + 1; j < array.Length; j++)
            {
                //if (temp == array[j])
                //{
                //    Console.WriteLine("{0}", array[j]);
                //    temp = 0;
                //}
                //else {
                //    if (temp > array[j])
                //    {
                //        temp -= array[j];
                //        Console.WriteLine("{0}", array[j]);
                //    }
                //    else
                //        break;
                //}
                sum += array[j];
            }
            if (result.Sum(x => x) == target)
            {
                return 0;
            }
            else
            {
                return recursivemethod(array,j,target);
            }
        }
        //Target capture
        //Checking the Target - current_value in an array
        //Check whether i can form the number	


        // Function to find all unique combination of
        // given elements such that their sum is K
        public void unique_combination(int l, int sum, int K, List<int> local, List<int> A)
        {
            // If a unique combination is found
            if (sum == K)
            {
                Console.Write("{");
                for (int i = 0; i < local.Count; i++)
                {
                    if (i != 0)
                        Console.Write(" ");
                    Console.Write(local[i]);
                    if (i != local.Count - 1)
                        Console.Write(", ");
                }
                Console.WriteLine("}");
                return;
            }

            // For all other combinations
            for (int i = l; i < A.Count; i++)
            {
                // Check if the sum exceeds K
                if (sum + A[i] > K)
                    continue;

                // Check if it is repeated or not
                if (i > l && A[i] == A[i - 1])
                    continue;
                // Take the element into the combination
                local.Add(A[i]);
                // Recursive call
                unique_combination(i + 1, sum + A[i], K, local, A);
                // Remove element from the combination
                local.RemoveAt(local.Count - 1);
            }
        }

        // Function to find all combination
        // of the given elements
        public void Combination(List<int> A, int K)
        {
            // Sort the given elements
            A.Sort();

            // To store combination
            List<int> local = new List<int>();

            unique_combination(0, 0, K, local, A);
        }
    }
}

