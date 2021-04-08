using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class TenDigitFibonacci
    {
        static void Main(string[] args)
        {
            //*****************************FIRST ATTEMPT********************************
            // Below was just an attempt to get the main functionality figured out, first.
            // Afterward, I moved on and refactored to make it more dynamic so I didn't 
            // have to enter an oversized number that I assumed would encompass the 
            // requirements.
            //**************************************************************************

            //long num2 = 2;
            //long num1 = 1;
            //List<string> fibList = new List<string>();

            //while (num2 <= 1000000000000)
            //{
            //    Console.WriteLine($"{num1}\n{num2}");
            //    fibList.Add(Convert.ToString(num1));
            //    fibList.Add(Convert.ToString(num2));
            //    num1 = num1 + num2;
            //    num2 += num1;
            //}

            //string tenDigitNum = fibList.Where(x => x.Length == 10).FirstOrDefault();
            //int indexOfNum = fibList.IndexOf(tenDigitNum);


            //Console.WriteLine($"First Index of 10 Digits: {indexOfNum}\nNumber contained in index: {tenDigitNum}");

            //Variables to be counted off of
            long num2 = 2;
            long num1 = 1;
            //Variable to hold the query to of number with 10 digits
            string tenDigitNum;
            //Variable to hold the index of tenDigitNum within the List fibList
            int indexOfNum;
            //Condition to be met in order to drop out of While loop
            bool conditionMet = false;
            //List to contain all of the fibonacci characters and query through
            List<string> fibList = new List<string>();

            //Keep running until the condition is switched to true (finding a number that is ten digits long)
            while (!conditionMet)
            {
                //Printed out values to ensure Fib sequence was calculating correctly
                //Console.WriteLine($"{num1}\n{num2}");
                //Convert num1 & num2 into strings so that I can 1) add them to the list
                //2) Use the .Length on them once the list is completed
                fibList.Add(Convert.ToString(num1));
                fibList.Add(Convert.ToString(num2));
                //Increment the numbers in accordance with the Fib sequence
                num1 = num1 + num2;
                num2 += num1;

                //Update tenDigitNum and indexOfNum in order to test the qualifications of the if statement against
                //current numbers
                tenDigitNum = fibList.Where(x => x.Length == 10).FirstOrDefault();
                indexOfNum = fibList.IndexOf(tenDigitNum);
                //if tenDigitNum != null, that means we have reached the first 10-digit number. That also means the
                //number was captured in the indexOfNum above, so now all we have left to do is print out the results
                //and drop out of the loop.
                if (tenDigitNum != null)
                {                    
                    Console.WriteLine($"First Index of 10 Digits: {indexOfNum}\nNumber contained in index: {tenDigitNum}");
                    conditionMet = true;
                }
            }//end While
        }//end main
    }//class
}//namespace
