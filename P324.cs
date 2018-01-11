/*
3.24 (Odd or Even) Write an app that reads an integer, then determines and displays whether it’s odd or even. 
[Hint: Use the remainder operator. An even number is a multiple of 2. Any multiple of 2 leaves a remainder of 0 when divided by 2.] 
*/

using System;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer1;
           
            Console.WriteLine("Enter an integer: ");
            integer1= int .Parse(Console.ReadLine());
           
           
          
            if (integer1 % 2 == 0 )
            {
                Console.WriteLine("the integer is even");
                Console.ReadLine();
            } 
            else
            {
                Console.WriteLine("the integer is odd");
                Console.ReadLine();
            }
        }
    }
}
