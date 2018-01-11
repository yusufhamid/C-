/* test class for tic tac toe */
using System;

class Program
{
    static void Main(string[] args)
    {
        string playername = " ";
        bool gameover = false;
        Console.WriteLine("");
        Console.WriteLine("************ Welcome To Tic-Tac-Toe Game ******************");
        Console.WriteLine();
        Console.WriteLine("\t 0\t 0\t 0");
        Console.WriteLine("\t 0\t 0\t 0");
        Console.WriteLine("\t 0\t 0\t 0");
        Console.WriteLine();
        Console.WriteLine("Who Wants To Start First");
        Console.Write("\tEnter First Player Name: ");
        playername = Console.ReadLine();
        TicTacToe player1 = new TicTacToe(1, playername);
        Console.Write("\tEnter Second Player Name: ");
        playername = Console.ReadLine();
        TicTacToe player2 = new TicTacToe(2, playername);
        Console.WriteLine("\t\t Ready? Good Luck!");
        Console.WriteLine();
        while (!gameover)
        {
            TicTacToe.intboard();
            while (!player1.playgame() && !player2.playgame())
                gameover = true;
            if (gameover)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    Console.WriteLine("Good bye");
                else
                    gameover = false;
            }
        }
        Console.ReadLine();
    }
}

