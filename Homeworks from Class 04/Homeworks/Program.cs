using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Program
    {
        static void FunWithStrings(string userInput)
        {
            // print the reverse string
            char[] chars = userInput.ToCharArray();

            for (int i = 0, j = userInput.Length - 1; i < j; i++, j--)
            {
                chars[i] = userInput[j];
                chars[j] = userInput[i];
            }
            Console.WriteLine(chars);

            // print total number of vowels
            int volwes = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u' ||
                    userInput[i] == 'A' || userInput[i] == 'E' || userInput[i] == 'I' || userInput[i] == 'O' || userInput[i] == 'U')
                {
                    volwes++;
                    Console.WriteLine("\nThe total number of vowel in the string is :{0}\n", volwes);
                }
            }

            // check if string is palindrome
            char[] array = userInput.ToCharArray();
            int stringLength = userInput.Length - 1;
            string newString = "";
            for (int i = stringLength; i < array.Length; i++)
            {
                newString = newString + Convert.ToString(array[i]);
                if (i == 0)
                {
                    break;
                }
                if (userInput == newString)
                {
                    Console.WriteLine("Entered string is Palindrome");
                }
                else
                {
                    Console.WriteLine("Entered string is not Palindrome");
                }
            }

            //  print the largest word  and smallest word
            userInput = userInput + " ";
            int len = userInput.Length;
            String k = " ", max = " ", min = " ";
            char ch;

            int p, max1 = 0;
            int min1 = len;

            for (int i = 0; i < len; i++)
            {
                ch = userInput[i];
                if (ch != ' ')
                {
                    k = k + ch;
                }
                else
                {
                    p = k.Length - 1;
                    if (p < min1)
                    {
                        min1 = p;
                        min = k;
                    }
                    if (p > max1)
                    {
                        max1 = p;
                        max = k;
                    }
                    k = " ";
                }
            }

            Console.Write("Shortest Word = " + min + "\n");
            Console.Write("Longest Word = " + max + "\n");


            // print the count of words
            Console.Write("Number or count of words is " + userInput.Length + "\n");

            // print the most used character
            int[] charCount = new int[256];
            int length = userInput.Length;
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < length; i++)
            {
                if (maxCount < charCount[userInput[i]])
                {
                    maxCount = charCount[userInput[i]];
                    character = userInput[i];
                }
                Console.WriteLine("Most used character is : " + character);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Homework No.1 Class 04");
            Console.WriteLine("Please enter string");
            string userInputValue = Console.ReadLine();
            FunWithStrings(userInputValue);

            Console.ReadLine();
        }
    }
}

