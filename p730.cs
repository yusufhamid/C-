

using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int rnumber;
        int guessnumber;
        //selects random number between 1-1000
        Random randomNumbers = new Random();
        rnumber = randomNumbers.Next(1, 1001);

        //user enters a number to get the random number selected
        Console.WriteLine("Guess a number between 1 and 1000");
        guessnumber = int.Parse(Console.ReadLine());

        //loop exception 
        while (guessnumber != rnumber)
        {
            if (guessnumber > rnumber)
            {
                Console.WriteLine("Too high. Try again");
                Console.WriteLine("Guess a number between 1 and 1000 again!");
                guessnumber = int.Parse(Console.ReadLine());
            }

            else if (guessnumber < rnumber)
            {
                Console.WriteLine("Too low. Try again");
                Console.WriteLine("Guess a number between 1 and 1000 again!");
                guessnumber = int.Parse(Console.ReadLine());
            }
        }
        if (guessnumber == rnumber)
        {
            Console.WriteLine("Congratualations. You guessed the number!");
        }
        Console.ReadLine();
    }
}

