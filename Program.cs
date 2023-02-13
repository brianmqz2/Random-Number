using System;
using static System.Console;
namespace ProgramAssignment3
{

    class Program

    {

        static void Main(string[] args)

        {

            /*This program generates random numbers and 

            the position for the maximum/minimum numbers*/

            int[] intArray = new int[50];

            Random randomNum = new Random();

            int randomNumber;

            /*The following for() loop outputs the 50 random 

            numbers in a 5 row by 10 column format*/

            for (int i = 0; i < intArray.Length; i++)

            {

                randomNumber = randomNum.Next(1, 100);//This code restricts the code from 1 <= x <= 99

                intArray[i] = randomNumber;

                {

                    /*This if() statement allows the 50 numbers 

                    to be outputted in a set of 10 columns*/

                    if (i % 10 == 0)

                        WriteLine("");

                    Write("{0, 4}", randomNumber);

                }

            }

            int maxNum = intArray[0], minNum = intArray[0];

            int posNum1 = 0, posNum2 = 0;

            /*This for() loop outputs the WriteLine part 

            of the program which gives us the

            maximum/minimum numbers and their position*/

            for (int i = 0; i < intArray.Length; i++)

            {

                //This gives us the maximum and its position

                if (intArray[i] > maxNum)

                {

                    maxNum = intArray[i];

                    posNum1 = i;

                }

                //This gives us the minimum and its position

                if (intArray[i] < minNum)

                {

                    minNum = intArray[i];

                    posNum2 = i;

                }

            }

            /*The following is what get outputted in the 

            terminal which is based of the randomly

            generated numbers and its position*/

            WriteLine("\n");

            WriteLine("The highest number is {0} and it is at position {1}", maxNum, posNum1);

            WriteLine("The lowest number is {0} and it is at position {1}", minNum, posNum2);

        }

    }
}