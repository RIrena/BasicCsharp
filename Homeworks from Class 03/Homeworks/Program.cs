using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homeworks from Class 03");

            #region Homework 1

            Console.WriteLine("------- Application SumOfEven -------");

            int[] numbersInput = new int[6];
            int sumOFEvenNumbers = 0;

            for (int i = 0; i < numbersInput.Length; i++)
            {
                Console.WriteLine("Enter integer no.1");
                numbersInput[i] = int.Parse(Console.ReadLine());
                
                if (i % 2 != 0)
                {
                   sumOFEvenNumbers += numbersInput[i];
                }
            }

            Console.WriteLine("The result of even numbers is " + sumOFEvenNumbers);

            #endregion

            #region Homework 2

            Console.WriteLine("------- Application StudentGroup -------");

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Vase", "Irena", "Gjorgi", "Martina", "Bojan" };

            Console.WriteLine("Please enter student group : (there are 1 and 2 )");

            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                foreach (string firstGroupStudents in studentsG1)
                {
                    Console.WriteLine(firstGroupStudents);
                }
            }
            else if (userInput == 2)
            {
                foreach (string secondGroupStudents in studentsG2)
                {
                    Console.WriteLine(secondGroupStudents);
                }
            }
            else
            {
                Console.WriteLine("Wrong input please enter (1 or 2 )");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
