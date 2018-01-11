/*
8.12 (Duplicate Elimination) Use a one-dimensional array to solve the following problem: 
Write an app that inputs five numbers, each between 10 and 100, inclusive. As each number 
is read, display it only if it’s not a duplicate of a number already read. Provide for 
the “worst case,” in which all five numbers are different. Use the smallest possible array 
to solve this problem. Display the complete set of unique values input after the user inputs
each new value.
*/

using System;

namespace p812.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            //define variables.
            int number = 0;
            int counter = 0;
            bool count = false;
            int[] numbers = new int[5];

            while (counter < 5) //while counter is less than five
            {
                count = false;
                //ask for input
                Console.WriteLine("Please enter a number between 10 and 100 ");
                number = int.Parse(Console.ReadLine());
                //while number is less than 10 or higher than 100, ask user to input the number again
                while (number < 10 || number > 100)
                {
                    Console.WriteLine("Re-enter a number between 10 and 100 ");
                    number = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < numbers.Length; i++) //if the number is duplicate, ask user to enter again
                {
                    if (number == numbers[i])
                    {
                        count = true;
                        Console.WriteLine("A Duplicate number. Please enter another number between 10 and 100 ");
                        counter = counter - 1;
                    }

                }
                // if the number isn't duplicate, put it into the array
                if (!count)
                    numbers[counter] = number;

                Console.Write("unique values input: ");
                foreach (var i in numbers)
                {
                    if (i >= 10)//output the array
                        Console.Write(i + " ");
                }
                Console.WriteLine(""); //new line of output
                counter++;

            }
            Console.ReadLine();
        }
    }
}

