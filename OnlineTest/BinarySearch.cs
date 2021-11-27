using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTest
{
    public class BinarySearch
    {
		public void BinarySearchFunc(int[] array, int target)
		{
			int result = RecursiveBinarySearch(array, target, 0, array.Length); //array,4,0,10
			Console.WriteLine(result == -1 ? "Not found in the list" : string.Format("Target : {0} found at : {1} place",target,result));
		}

		private int RecursiveBinarySearch(int[] array, int target, int min, int max)
		{
			int mid = (min+max)/2;
			if (mid == array.Length - 1 && target != array[mid])
			{
				return -1;
			}
			if (target == array[mid]) {				
				return mid;				
			}
			else if (target > array[mid]) //5>a[4]=>6
			{
				return RecursiveBinarySearch(array, target, mid,max);
			}
			else
			{
				return RecursiveBinarySearch(array, target, min, mid);
			}
		}
	}
}
