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
