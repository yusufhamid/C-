/*
10.10 (Tic-Tac-Toe) Create class TicTacToe that will enable you to write a complete app to play the game of Tic-Tac-Toe. 
The class contains a private 3-by-3 rectangular array of integers. The constructor should initialize the empty board to all 0s.
Allow two human players. Wherever the first player moves, place a 1 in the specified square, and place a 2 wherever the second
player moves. Each move must be to an empty square. After each move, determine whether the game has been won and whether it’s a draw.
If you feel ambitious, modify your app so that the computer makes the moves for one of the players. Also, allow the player to 
specify whether he or she wants to go first or second. If you feel exceptionally ambitious, develop an app that will play
three-dimensional Tic-Tac-Toe on a 4-by-4-by-4 board.
*/

using System;

class TicTacToe
{
    static int[,] board;
    string pname;
    //constructer that accepts player number and name
    public TicTacToe(int player, string playername)
    {
        Playername = playername;
        Player = player;
        board = new int[3, 3]; // two dimentional array

    }
    public int Player { get; set; }
    public string Playername
    {
        get
        {  //gets the player name
            return pname;
        }
        set
        {
            if (value.Length > 0)
                pname = value;
            else
            {//loop until something is entered
                while (value.Length < 1)
                {
                    Console.Write("wrong entry, enter players name: ");
                    value = Console.ReadLine();
                }
            }
        }
    }
    public bool playgame()
    {


        int r = 0;
        int c = 0;
        Random rand1 = new Random();
        Random rand2 = new Random();

        if (Playername != "computer")
        {
            Console.WriteLine("\t-----------------------");
            Console.WriteLine("\t" + Playername + "'s turn");
            Console.Write("\t\tEnter the row you want to place = ");
            int.TryParse(Console.ReadLine().Trim(), out r);
            Console.Write("\t\tEnter the column you want to place = ");
            int.TryParse(Console.ReadLine().Trim(), out c);
            Console.WriteLine();
            Console.WriteLine("\t\t// Nice move " + Playername + "!");
            Console.WriteLine();
        }
        else
        {
            r = rand2.Next(1, 4);
            c = rand2.Next(1, 4);
        }
        while (!checkboard(r, c))
        {
            if (Playername != " computer")
            {
                Console.WriteLine("Oops! You entered wrong row and/or column. ");
                Console.WriteLine("The game will be retarted. Press Enter");
                int.TryParse(Console.ReadLine().Trim(), out r);
                int.TryParse(Console.ReadLine().Trim(), out c);
                return true;
            }

            else
            {
                r = rand2.Next(1, 4);
                c = rand2.Next(1, 4);

            }
        }
        board[r - 1, c - 1] = Player;
        displayboard();

        if (win())
        {
            Console.WriteLine(" " + Playername + ", CONGRATULATION YOU WIN!");
            return true;

        }
        else if (draw())
        {
            Console.WriteLine("Its a Draw. ");
            Console.WriteLine("Try Again. Press Enter");
            return true;
        }
        return false;

    }

    private bool win()
    {
        if (board[0, 0].Equals(Player) && board[0, 1].Equals(Player) && board[0, 2].Equals(Player))
            return true;
        if (board[1, 0].Equals(Player) && board[1, 1].Equals(Player) && board[1, 2].Equals(Player))
            return true;
        if (board[2, 0].Equals(Player) && board[2, 1].Equals(Player) && board[2, 2].Equals(Player))
            return true;
        //c
        if (board[0, 0].Equals(Player) && board[1, 0].Equals(Player) && board[2, 0].Equals(Player))
            return true;
        if (board[0, 1].Equals(Player) && board[1, 1].Equals(Player) && board[2, 1].Equals(Player))
            return true;
        if (board[0, 2].Equals(Player) && board[1, 2].Equals(Player) && board[2, 2].Equals(Player))
            return true;
        //diagonals
        if (board[0, 0].Equals(Player) && board[1, 1].Equals(Player) && board[2, 2].Equals(Player))
            return true;
        if (board[0, 2].Equals(Player) && board[1, 1].Equals(Player) && board[2, 0].Equals(Player))
            return true;


        return false;



    }
    private bool draw()
    {
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                if (board[r, c] != 1 && board[r, c] != 2)
                    return false;
            }
        }
        return true;
    }
    private bool checkboard(int r, int c)
    {
        bool fine = false;
        if (r > 3 || c > 3)

            return false;
        if (board[r - 1, c - 1] != 1 && board[r - 1, c - 1] != 2)
            fine = true;
        return fine;
    }
    //initiallizing the 2dimention board
    public static void intboard()
    {
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
                board[r, c] = 0;
        }
        displayboard();
    }
    private static void displayboard()
    {
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
                Console.Write("\t" + board[r, c]);

            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

