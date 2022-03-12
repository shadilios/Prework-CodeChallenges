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
            
            

            // Problem 1
            void ArrayMaxResult()
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
                    Console.Write(arrayNums[i]+ " ");
                }

                //Show user his array
                Console.WriteLine("is your array, now select a number from the array!");

                int a = Convert.ToInt32(Console.ReadLine());

                

                int FinalFunction(int[] passedArray, int x)
                {
                    int counter = 0;
                    for (int i = 0; i < passedArray.Length; i++)
                    {
                        if (passedArray[i] == x)
                        {
                            counter++;
                        }
                    }

                    return counter * x;
                    
                }
                Console.WriteLine("Your computated score is: ");
                Console.WriteLine(FinalFunction(arrayNums, a));

            }
            //**********************************

            // Problem 2
            void LeapYearCalculator()
            {
                Console.WriteLine("Input a year to check if it's a leap year or not!");
                int leapYear = Convert.ToInt32(Console.ReadLine());

                if ((leapYear%4 == 0 && leapYear%100 != 100) || leapYear%400 ==0)
                {
                    Console.WriteLine($"{leapYear} is a Leap Year!");
                }
                else
                {
                    Console.WriteLine($"{leapYear} is NOT a Leap Year!");

                }


            }

            // Problem 3

            int[] arr = { 1, 3, 2 };

            string PerfectSequence(int[] someArray)
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

                return myBool;                              
            }

            // Problem 4
            void SumOfRows()
            {

                int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };

                int[] CalculateSum(int[,] array)
                {
                    int num = array.Rank;
                    int elementsPerRow = array.Length / array.Rank;
                    int sum = 0;

                    int[] returnValue = new int[num];

                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < elementsPerRow; j++)
                        {
                            sum += array[i, j];
                        }

                        returnValue[i] = sum;
                        sum = 0;
                    }

                    return returnValue;
                }


                CalculateSum(myArray);


                //Console.WriteLine($"[{x} , {y}, {z}]");
            }






            //  Running Problems: 

            //  ArrayMaxResult();
            //  LeapYearCalculator();
            //  Console.WriteLine(PerfectSequence(arr));
            //  SumOfRows();

            //This to make console not close unless we press a key
            Console.ReadKey();
        }
    }
}
