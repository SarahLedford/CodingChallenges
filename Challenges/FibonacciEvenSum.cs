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
            /*************************INSTRUCTIONS*************************************
             * Each new term in the Fibonacci sequence is generated
             * by adding the previous two terms. By starting with
             * 1 and 2, the first 10 terms will be:
             *
             * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
             *
             * By considering the terms in the Fibonacci sequence whose values 
             * do not exceed four million, find the sum of the even-valued terms.
             * *************************************************************************
             */
            #region First Try
            //I had tried to refactor my fibonacci solution, but it does not come up with the correct answer of total being just over 4million

            ////First number in Fib sequence
            //long num1 = 1;

            ////Running total variable to keep track of sum
            //long total = 0;

            ////For loop iterates through the specified count and increments num2 by adding num1 onto it
            //for (long num2 = 1; num2 <= 4000000;)
            //{
            //    //Printing out the values in testing to ensure Fib sequence is calculating correctly
            //    Console.WriteLine($"{num1}\n{num2}");
            //    if (num2 % 2 == 0)
            //    {
            //        //Printed out the even numbers to ensure they were being correctly selected
            //        //Console.WriteLine($"Even: {num2}");
            //        total += num2;
            //    }
            //    else if (num1 % 2 == 0)
            //    {
            //        //Printed out the even numbers to ensure they were being correctly selected
            //        //Console.WriteLine($"Even: {num1}");
            //        total += num1;
            //    }

            //    //num1 is changed before num2 to ensure an accurate addition
            //    num1 += num2;
            //    num2 += num1;

            //}
            //Console.WriteLine($"Total: {total}"); 
            #endregion



            int num2 = 2;
            int num1 = 1;
            int total = 0;

            while (num2 <= 4000000)
            {



                if (num2 % 2 == 0)
                {
                    total += num2;
                    //Console.WriteLine($"Even: {num2}");
                }
                else if (num1 % 2 ==0)
                {
                    total += num1;
                    //Console.WriteLine($"Even: {num1}");
                }
                Console.WriteLine($"{num1}\n{num2}");
                num1 = num1 + num2;
                num2 += num1;
            }
            Console.WriteLine($"Total: {total}");
        }//end main
    }//end class
}//end namespace
