using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class LongestCollatz
    {
        static void Main(string[] args)
        {
            /*************************INSTRUCTIONS*************************************
             * The following iterative sequence is defined for the set of positive integers:
             * n → n/2 (n is even)
             * n → 3n + 1 (n is odd)
             * 
             * Using the rule above and starting with 13, we generate the following sequence:
             * 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
             * 
             * It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it
             * has not been proven yet (Collatz Problem), it is thought that all starting numbers finish at 1.
             * Which starting number, under one thousand, produces the longest chain?
             * 
             * NOTE: Once the chain starts the terms are allowed to go above one thousand.
             * *************************************************************************
             * 
             * ***************************STEPS***************************
             * 1) Iterate through the Collatz Problem and print the results
             *    to ensure the correct values are being calculated.
             *    
             * 2) Iterate through the Collatz Problem on every number up to
             *    (but not including) 1000 and check to see the length of the
             *    chain.
             *    
             * 3) Store the number of indexes for each Collatz iteration
             *    in a collection and use a .Max() to identify the largest
             *    chain
             *    
             * 3) Display the starting number of the longest chain
             * ***********************************************************
             */
            List<int> collatz = new List<int>();
            int counter = 1;
            int num;            

            for (int i = 1; i <= 999; i++)
            {
                //This sets the starting number since i is going to increment all the way up to (and including) 999
                num = i;
                //once num reaches the value of 1, it drops out of the while and starts the next loop of the ForLoop
                //This is because 1 is the end of a sequence of Collatz
                while (num != 1)
                {
                    //if num is even, it falls in here
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                        //Increasing by 1 to show how many chains we have gone through
                        counter++;
                    }
                    //else, if num is odd, it falls in here
                    else if (num % 2 != 0)
                    {
                        num = num * 3 + 1;
                        //Increasing by 1 to show how many chains we have gone through
                        counter++;
                    }

                }//end while
                //this adds the number of chains in the most recent interation to the List
                collatz.Add(counter);
                //this resets the counter so it can be used for the next iteration, AFTER it has been used to update
                //the List
                counter = 1;
            }//end for

            //Print out the results
            //cast to an int (even though it says it's unnecessary) because that's how adding the 1 on works
            //(otherwise it would be 51 instead of 5, for example)                    V
            Console.WriteLine($"Number that produces the highest amount of chains: { (int)collatz.IndexOf(collatz.Max()) + 1}" +
                $"\nHighest Number of Chains: {collatz.Max()}\n" +
                $"Index of Starting Number with Highest Amount of Chains: {collatz.IndexOf(collatz.Max())}");          
        }//end Main
    }//end class
}//end namespace
