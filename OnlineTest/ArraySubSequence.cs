using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTest
{
   public class ArraySubSequence
    {
		public bool IsValidSubsequence(List<int> array, List<int> sequence)
		{
			// Write your code here.
			int sequencepoiner = 0;
			if (sequence.Count <= array.Count)
			{
				for (int i = sequencepoiner; i < array.Count; i++)
				{
					if (array[i] == sequence[sequencepoiner])
					{
						sequencepoiner++;
						if (sequencepoiner == sequence.Count)
							break;
					}
				}
			}
			return sequencepoiner == sequence.Count;
		}
	}
}
