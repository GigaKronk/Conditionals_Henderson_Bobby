using System;

namespace Conditionals_Henderson_Bobby
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter whole number, please! ");
            int myWholeNum = Convert.ToInt32(Console.ReadLine());

            // checks if positive or negtive
            if (myWholeNum >= 0)
            {
                Console.WriteLine($"{myWholeNum} is a positive number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a negative number");
            }

            // Checks if even or odd
            if (myWholeNum % 2 == 0)
            {
                Console.WriteLine($"{myWholeNum} is an even number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is an odd number!");
            }

            // Creates two more integer numbers
            int num1 = 6;
            int num2 = 99;

            // gets first max
            int firstMax = Math.Max(myWholeNum, num1);
            // Gets maximum number
            int max = Math.Max(firstMax, num2);

            //prints max to console
            Console.WriteLine($"The maximum number of {myWholeNum}, {num1}, and {num2} is {max}!");

            // Asks user to enter a grade and assigns it to a char variable, grade
            Console.WriteLine("Enter a grade (A, B, C, D, F)!");
            char grade = Console.ReadKey().KeyChar;

            //Prints description based on grade value
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'b':
                    Console.WriteLine("\nVery Good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'd':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'f':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    Console.WriteLine("\nYou did not enter a valid grade!");
                    break;
               
            }

        }
    }
}
