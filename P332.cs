/*
3.32 (Car-Pool Savings Calculator) Research several car-pooling websites. Create an app that calculates your daily driving cost, 
so that you can estimate how much money could be saved by car pooling, which also has other advantages such as reducing carbon
emissions and reducing traffic congestion. The app should input the following information and display the user’s cost per day of 
driving to work:

a. Total miles driven per day.

b. Cost per gallon of gasoline (in cents).

c. Average miles per gallon.

d. Parking fees per day (in cents).

e. Tolls per day (in cents).
*/
using System;

class MainClass
{
    public static void Main()
    {
        double dailydrivingcost;
        double totalmiles;
        double gasolinecost;
        double milespergallon;
        double parkingfees;
        double tolls;

        Console.WriteLine("Enter total miles driven per day: ");
        totalmiles = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter cost per gallon of gasoline (in cent: ");
        gasolinecost = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter average miles per gallon: ");
        milespergallon = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter parking fees per day (in cents): ");
        parkingfees = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter tolls per day (in cents): ");
        tolls = double.Parse(Console.ReadLine());

        dailydrivingcost = (totalmiles / milespergallon) * gasolinecost + parkingfees + tolls;

        Console.WriteLine($"Your daily driving cost is ${dailydrivingcost}");


        if (dailydrivingcost > 4)
        {
            Console.WriteLine("Save money. Consider car pooling!!!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You don't need carpooling.!!!");
            Console.ReadLine();
        }
    }
}
