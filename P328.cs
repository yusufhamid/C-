using System;

class MainClass
{
    public static void Main()
    {
        int number;
        int digit0;
        int digit1;
        int digit2;
        int digit3;
        int digit4;


        Console.Write("Enter any four digit number: ");
        number = int.Parse(Console.ReadLine());

        digit4 = number % 10;
        digit3 = (number % 100) / 10;
        digit2 = (number % 1000) / 100;
        digit1 = (number % 10000) / 1000;
        digit0 = (number % 100000) / 10000;


        Console.WriteLine($"Here:  {digit0}   {digit1}   {digit2}   {digit3}   {digit4}");

        Console.Write($"Or other ways \n {digit0} \n {digit1} \n {digit2} \n {digit3} \n {digit4}");
        Console.Read();
    }
}