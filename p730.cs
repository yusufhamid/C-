/*
7.30 (Guess-the-Number Game) Write an app that plays “guess the number” as follows: 
Your app chooses the number to be guessed by selecting a random integer in the range 1 to 1000.
The app displays the prompt Guess a number between 1 and 1000. The player inputs a first guess.
If the player’s guess is incorrect, your app should display Too high. Try again. or Too low. Try again.
to help the player “zero in” on the correct answer. The app should prompt the user for the next guess. 
When the user enters the correct answer, display Congratulations. You guessed the number! and allow the
user to choose whether to play again.
*/

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

