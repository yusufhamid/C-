/*
3.28 (Digits of an Integer) Write an app that inputs one number consisting of five digits from the user, 
separates the number into its individual digits and displays the digits separated from one another by
three spaces each. For example, if the user types 42339, the app should display
4 2 3 3 9
Assume that the user enters the correct number of digits. What happens when you execute the app and type
a number with more than five digits? What happens when you execute the app and type a number with fewer
than five digits? [Hint: It’s possible to do this exercise with the techniques you learned in this chapter. 
You’ll need to use both division and remainder operations to “pick off” each digit.]
*/

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
