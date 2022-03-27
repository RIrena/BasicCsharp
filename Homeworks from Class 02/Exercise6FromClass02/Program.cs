using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6FromClass02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 06 - from Class 2");

            //Create two variables and initialize  them with a keyboard input
            int number1;
            int number2;
            Console.WriteLine("Please enter first number ");
            bool ifSuccessfull = int.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Please enter second number");
            bool ifSuccessFull = int.TryParse(Console.ReadLine(), out number2);


            // Write code that can test which number is larger
            if (number1 > number2)
            {
                Console.WriteLine("First number is larger then second");
            }
            else if (number2 > number1)
            {
                Console.WriteLine("Second number is larger then first");
            }
            else
            {
                Console.WriteLine("Numbers are same");
            }

            // Write code that can test the numbers whether they are even or odd
            if (number1 % 2 == 0)
            {
                Console.WriteLine("First 1 is EVEN");
            }
            else
            {
                Console.WriteLine("First 1 is ODD");
            }
            if (number2 % 2 == 0)
            {
                Console.WriteLine("Second 2 is EVEN");
            }
            else
            {
                Console.WriteLine("Second 2 is ODD");
            }

            // Write the larger number from the two in the console
            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2);

            }

            //After that write if the number is even or odd
            if (number1 % 2 == 0)
            {
                Console.WriteLine("Larger number is EVEN");
            }
            else if (number2 % 2 == 0)
            {
                Console.WriteLine("Larger number is EVEN");
            }
            else
            {
                Console.WriteLine("Larger number is ODD");
            }

            Console.ReadLine();
        }
    }
}
