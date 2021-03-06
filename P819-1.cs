/*
8.19 (Airline Reservations System) A small airline has just purchased a computer for its new automated reservations system.
You have been asked to develop the new system. You’re to write an app to assign seats on each flight of the airline’s only 
plane (capacity: 10 seats).

Display the following alternatives: Please type 1 for First Class and Please type 2 for Economy. If the user types 1,
your app should assign a seat in the first-class section (seats 1–5). If the user types 2, your app should assign a 
seat in the economy section (seats 6–10).

Use a one-dimensional array of type bool to represent the seating chart of the plane. Initialize all the elements 
of the array to false to indicate that all the seats are empty. As each seat is assigned, set the corresponding 
element of the array to true to indicate that the seat is no longer available.

Your app should never assign a seat that has already been assigned. When the economy section is full, 
your app should ask the person if it’s acceptable to be placed in the first-class section (and vice versa). 
If yes, make the appropriate seat assignment. If no, display the message "Next flight leaves in 3 hours."
*/

using System;
class airline
{
    public static int checkFirstClass(out int seatsFirst, bool[] seats) //check available First Class 
    {
        seatsFirst = 0;
        for (int i = 0; i < 5; i++)
        {
            if (seats[i] == false)
                seatsFirst++;
        }
        return seatsFirst;
    }

    public static int checkEconomy(out int seatsEconomy, bool[] seats) //check available Economy 
    {
        seatsEconomy = 0;
        for (int j = 5; j < 10; j++)
        {
            if (seats[j] == false)
                seatsEconomy++;
        }
        return seatsEconomy;
    }

    public static void reserveFirstSeat(ref bool[] seats, ref int i) // reserve first class seat 
    {
        if (i < 5)
        {
            if (seats[i] == false)
            {
                seats[i] = true;
            }
        }
        ++i;
    }

    public static void reserveEconomySeat(ref bool[] seats, ref int j) // reserve economy class seat
    {
        if (j > 5 || j < 10)
        {
            if (seats[j] == false)
            {
                seats[j] = true;
            }
        }
        ++j;
    }

    //main method
    static void Main()
    {
        Boolean[] r = new Boolean[10];
        int seatsFirst, seatsEconomy, reserve, exit, f = 1, e = 5, i = 0, j = 5;
        bool[] seats = { false, false, false, false, false,
                         false, false, false, false, false, false, false}; // seating chart 

        do
        {
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~ WELCOME TO AIRLINE RESERVATION ~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("There are " + checkFirstClass(out seatsFirst, seats) + " first class seats and " + checkEconomy(out seatsEconomy, seats) + " economy seats are remainig."); // check available seats
                Console.WriteLine("\t\tPLEASE CHOOSE:");
                Console.WriteLine("\t\t1. FIRST CLASS");
                Console.WriteLine("\t\t2. ECONOMY");

                reserve = int.Parse(Console.ReadLine());

                if (reserve == 1)
                {
                    reserveFirstSeat(ref seats, ref i); // reserve first class seat
                }
                if (reserve == 2)
                {
                    reserveEconomySeat(ref seats, ref j); // reserve economy class seat
                }
                break;
            }

            //Output result             
            switch (reserve)
            {
                //first class output result
                case 1:

                    if (f <= 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have SUCCESSFULLY reserved a first class seat!");
                        Console.WriteLine("Your Seat Number is => #" + f);
                        Console.WriteLine("Thanks!");
                        Console.WriteLine();
                        f++;
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("The first class seat is full.");
                        Console.WriteLine("Would you like a economy seat?(1.yes\t2.no)");
                        int full = int.Parse(Console.ReadLine());
                        if (full == 1)
                        {
                            Console.WriteLine("Press 1 to go to the Main Menu.");
                        }

                        else
                        {
                            Console.WriteLine("next flight leaves in 3 hours.");
                        }
                    }
                    break;

                //Economy seat output result
                case 2:

                    Console.WriteLine();
                    e++;

                    if ((e > 5) && (e <= 10))
                    {
                        Console.WriteLine("You have SUCCESSFULLY reserved an economy seat!");
                        Console.WriteLine("Your Seat Number is => #" + e);
                        Console.WriteLine("Thanks!");
                        Console.WriteLine();
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("The economy class seat is full.");
                        Console.WriteLine("Would you like a first class seat?(1.yes\t2.no)");

                        int full = int.Parse(Console.ReadLine());

                        if (full == 1)
                        {
                            Console.WriteLine("Press 1 to go to the Main Menu.");
                        }

                        else
                        {
                            Console.WriteLine("Next Flight Leaves in 3 hours.");
                        }
                    }

                    break;
            }

            Console.WriteLine();
            Console.WriteLine("1.main menu\t2.exit");

            exit = int.Parse(Console.ReadLine());
        }

        while (exit == 1);

        Console.WriteLine("~~~~~~~~~~~~~ Have a Nice Trip!~~~~~~~~~~~~~~~");
        Console.ReadLine();
    }
}



