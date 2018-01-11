using System;


class practice
{
    static void Main(string[] args)
    {

        BodyMass();
    }
    static void BodyMass()
    {
        double weight;
        double height;
        double BMI;
        Console.WriteLine("Enter your weight in pound: ");
        weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter your height in inches: ");
        height = double.Parse(Console.ReadLine());
        BMI = (weight / Math.Pow(height, 2)) * 703;
        
        if (BMI < 18.5)
        {
            Console.WriteLine(BMI + ": Underweight");
            
        }
        else if (BMI >= 18.5 && BMI <= 24.9)
        {
            Console.WriteLine(BMI + ": Normal");
           
        }
        else if (BMI >= 25 && BMI <= 29.9)
        {
            Console.WriteLine(BMI + ":Overweight");
           
        }
        else if (BMI >= 30)
        {
            Console.WriteLine(BMI + ": Obese");
           

        }
        Console.WriteLine("BMI Values");
        Console.WriteLine("Underweight: less than 18.5 \n Normal: between 18.5 and 24.9 \n Overweight: between 25 and 29.9 \n Obese: 30 and greater");
        Console.ReadLine();
    }



}


