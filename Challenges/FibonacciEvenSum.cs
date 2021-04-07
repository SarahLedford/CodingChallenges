using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class FibonacciEvenSum
    {
        static void Main(string[] args)
        {
            //First number in Fib sequence
            long num1 = 1;

            //Running total variable to keep track of sum
            long total = 0;

            //For loop iterates through the specified count and increments num2 by adding num1 onto it
            for (long num2 = 1; num2 <= 4000000; num2 += num1)
            {
                //Printing out the values in testing to ensure Fib sequence is calculating correctly
                //Console.WriteLine($"{num1}\n{num2}");
                if (num2 % 2 == 0)
                {
                    //Printed out the even numbers to ensure they were being correctly selected
                    //Console.WriteLine($"Even: {num2}");
                    total += num2;
                }
                else if (num1 % 2 == 0)
                {
                    //Printed out the even numbers to ensure they were being correctly selected
                    //Console.WriteLine($"Even: {num1}");
                    total += num1;
                }

                //num1 is changed before num2 to ensure an accurate addition
                num1 += num2;
                
            }
            Console.WriteLine($"total: {total}");


        }//end main
    }//end class
}//end namespace
