using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTest
{
    public class Factorialusingrecursion
    {
		public int Factorial(int fact)
		{
			if (fact == 1)
				return 1;
			return fact * Factorial(fact - 1);
		}

		public int digitsum(int num)
		{
			if (num < 1)
				return 0;
			int digit = num % 10;
			num = num / 10;
			return digit + digitsum(num);
		}
	}
}
