using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTest
{
    public class PrimeFactors
    {        
        public void getprimefactors(long no, int i, int prodc = 0)
        {
            int product = prodc;
            // Checking if the number is less than N
            if (i <= no)
            {
                if (no % i == 0)
                {
                    Console.WriteLine(i);
                    if (product == 0)
                        product = i;
                    else
                        product *= i;   
                    if(product == no)
                        Console.WriteLine("Finally => ",i);
                }

                // Calling the function recursively
                // for the next number
                getprimefactors(no, i + 1, product);
            }
        }

        public int Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);//Recursive call    

        }
    }
}
