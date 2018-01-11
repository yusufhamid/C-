/*
6.16 (Displaying a Bar Chart) One interesting application of computers is to display graphs and bar charts.
Write an app that reads three numbers between 1 and 30. For each number that’s read, your app should display
the same number of adjacent asterisks. For example, if your app reads the number 7, it should display *******.
*/
using System;
class MainClass
{
    public static void Main(string[] args)
    {
        //declare variables 
        int i;
        int k;
        int number1;
        int number2;
        int number3;
        //ask the user to enter 3 numbers
        Console.WriteLine("Enter the number between 1 to 30: ");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number between 1 to 30: ");
        number2 = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter the third number between 1 to 30: ");
        number3 = int.Parse(Console.ReadLine());

        //runs until the exception is reached
        for (i = 1; i <= 1; i++)
        {
            if (number1 > 30 || number2 > 30 || number3 > 30 || number1 < 1 || number2 < 1 || number3 < 1)
            {
                Console.WriteLine("The number you entered is not between 1 to 30. Re enter:");

            }
            else
            {
                //prints stars for the number that are entered
                for (k = 1; k <= number1; k++)
                    Console.Write("*");
                Console.WriteLine();
                for (k = 1; k <= number2; k++)
                    Console.Write("*");
                Console.WriteLine();
                for (k = 1; k <= number3; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        Console.ReadLine();
    }
}

