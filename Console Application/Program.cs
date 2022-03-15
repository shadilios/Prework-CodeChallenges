using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application
{
    class Program
    {


        static void Main(string[] args)
        {

            #region Test ArrayMaxResult

            //Uncomment the function call to test
            //ArrayMaxResult();

            #endregion

            //******************************************

            #region Test LeapYearCalculator

            //uncomment the following function call to test
            //LeapYearCalculator();

            #endregion

            //******************************************

            #region Test PerfectSequence

            //edit this array to test different arrays
            int[] myArray = { 1, 2, 3 };

            //Uncomment this function call to test
            //PerfectSequence(myArray);

            #endregion

            //******************************************

            #region Test SumOfRows

            //Uncomment the following to test
            
            /*
            int[,] extraArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };

            int[] summedArray = SumOfRows(extraArray);

            for (int i = 0; i < summedArray.Length; i++)
            {
                Console.WriteLine(summedArray[i]);
            }
            */
            #endregion

            //******************************************


            //this line to make console not close after the program finishes
            Console.ReadLine();


        }





        static int ArrayMaxResult()
        {
            //  create an array with a size of 5 to have numbers in
            int[] arrayNums = new int[5];

            // tell user to input his array elements
            Console.WriteLine("Please input 5 numbers between 1-10, which will be in your array");

            //loop 5 times and ask for input to add to the array
            for (int i = 0; i < arrayNums.Length; i++)
            {
                arrayNums[i] = Convert.ToInt32(Console.ReadLine());
            }

            //loop to print it
            for (int i = 0; i < arrayNums.Length; i++)
            {
                Console.Write(arrayNums[i] + " ");
            }

            //Show user his array
            Console.WriteLine("is your array, now select a number from the array!");

            //store the inputted value into a
            int a = Convert.ToInt32(Console.ReadLine());


            int counter = 0;

            for (int i = 0; i < arrayNums.Length; i++)
            {
                if (arrayNums[i] == a)
                {
                    counter++;
                }

            }

            Console.WriteLine("Your computated score is: ");
            Console.WriteLine(counter * a);

            return counter * a;

            

            
            
        }

        static void LeapYearCalculator()
        {
            Console.WriteLine("Input a year to check if it's a leap year or not!");
            int leapYear = Convert.ToInt32(Console.ReadLine());

            if ((leapYear % 4 == 0 && leapYear % 100 != 100) || leapYear % 400 == 0)
            {
                Console.WriteLine($"{leapYear} is a Leap Year!");
            }
            else
            {
                Console.WriteLine($"{leapYear} is NOT a Leap Year!");

            }
        }


        static string PerfectSequence(int[] someArray)
        {
            int multiplicationCounter = 1;
            int sumCounter = 0;
            string myBool = "";
            for (int i = 0; i < someArray.Length; i++)
            {
                multiplicationCounter *= someArray[i];
                sumCounter += someArray[i];
                /*debug
                Console.WriteLine($"SumCounter : {sumCounter}");
                Console.WriteLine($"Multi counter : {multiplicationCounter}");
                */
                // if any of the elements is negative, then no
                if (someArray[i] < 0)
                {
                    myBool = "No";
                }
            }

            if (multiplicationCounter == sumCounter)
            {
                myBool = "Yes";
            }
            else
            {
                myBool = "No";
            }

            Console.WriteLine(myBool);

            return myBool;
        }

        static int[] SumOfRows(int[,] someArray)
        {

            int sum = 0;

            int[] returnValue = new int[someArray.GetLength(0)];

            //double loop using the GetLength , and add elements with i,j index according to the loop
            //outside loop will loop 3 times, and inside loop will loop 5 times for each element of the 3
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    sum += someArray[i, j];
                }

                returnValue[i] = sum;
                sum = 0;
            }

            return returnValue;





        }


        
    }
}
