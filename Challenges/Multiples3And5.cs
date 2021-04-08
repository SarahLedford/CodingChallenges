using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class Multiples3And5
    {
        static void Main(string[] args)
        {
            /*************************INSTRUCTIONS*************************************
             * If we list all the natural numbers below 10
             * that are multiples of 3 or 5, we get 3, 5,
             * 6 and 9. The sum of these multiples is 23.
             *
             * Find the sum of all the multiples of 3 or 5 below 1000 and print
             * it out to the console.
             * *************************************************************************
             */


            //This is a variable to hold the sum to be displayed
            int total = 0;

            //This will loop through the numbers up to 1000
            for (int i = 0; i < 1000; i++)
            {
                //This checks to see if the current number is evenly divisible by 3 or 5
                //(if there is no remainder when i is divided by 3 or 5, it gets added to the total)
                if (i % 3 == 0 || i % 5 == 0)
                {
                    //This adds the numbers that meet the above criteria to the total
                    total += i;
                }
            }
          
            //Print out the total
            Console.WriteLine(total);
        }
    }
}
