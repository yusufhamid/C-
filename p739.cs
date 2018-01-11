
using System;


namespace CAI
{
    class Program
    {


        static void Main(string[] args)
        {
            // Picks random number
            Random rnd = new Random();
            int rndnumber1 = rnd.Next(10);
            //picks second random number
            int rndnumber2 = rnd.Next(10);
            int x;
            //displays the random  numbers
            Console.WriteLine(rndnumber1);
            Console.WriteLine(rndnumber2);

            Console.WriteLine($"how much is " + rndnumber1 + " times " + rndnumber2);

            x = int.Parse(Console.ReadLine()); //reads the users answer


            //runs until the x= the correct answer
            while (x != rndnumber1 * rndnumber2)
            {

                Console.WriteLine("no, please try again");
                Console.WriteLine($"how much is " + rndnumber1 + " times " + rndnumber2);
                // Console.ReadLine();
                x = int.Parse(Console.ReadLine());
                //Console.ReadLine();
            }
            if (x == rndnumber1 * rndnumber2) //indicates stop
            {
                Console.WriteLine("very good");
                Console.ReadLine();
            }
        }
    }
}
