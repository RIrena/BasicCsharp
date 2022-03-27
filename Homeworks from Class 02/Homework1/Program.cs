using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homeworks from Class 02");
            #region Homework1

            Console.WriteLine("---------- REAL CALCULATOR ----------");

            int inputFirstNumber = 0;
            int inputSecondNumber = 0;
            int Calculation;

            Console.WriteLine("Enter the First Number");
            inputFirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            inputSecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation:");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine("The result is:" + (inputFirstNumber + inputSecondNumber));
                    break;
                case "-":
                    Console.WriteLine("The result is:" + (inputFirstNumber - inputSecondNumber));
                    break;
                case "*":
                    Console.WriteLine("The result is:" + (inputFirstNumber * inputSecondNumber));
                    break;
                case "/":
                    Console.WriteLine("The result is:" + (inputFirstNumber / inputSecondNumber));
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }

            #endregion

            #region Homework2
            Console.WriteLine("----------- AVERAGE NUMBER ----------- ");

            Console.WriteLine("Enter the First Number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Four Number");
            int fourNumber = Convert.ToInt32(Console.ReadLine());

            int OutPut = (firstNumber + secondNumber + thirdNumber + fourNumber) / 4;

            Console.WriteLine("The average of :" + firstNumber + " , " + secondNumber + "  ,  " + thirdNumber + "  and  " + fourNumber + "  is :  " + OutPut);

            #endregion

            #region Homework 3

            Console.WriteLine("----------- SWAP NUMBERS -----------");

            int firstSwapNumber = 5;
            Console.WriteLine("Input the First Number:" + firstSwapNumber);
            int secondSwapNumber = 8;
            Console.WriteLine("Input the Second Number:" + secondSwapNumber);
            int swap;

            swap = firstSwapNumber;
            firstSwapNumber = secondSwapNumber;
            secondSwapNumber = swap;

            Console.WriteLine("***** After swapping numbers ****");
            Console.WriteLine("First Number is :" + firstSwapNumber);
            Console.WriteLine("Second Number is :" + secondSwapNumber);

            #endregion

            Console.ReadLine();
        }
    }
}
