
using System;
namespace p411.cs
{



    class class1
    {
        static void Main()
        {
            //create the objects
            employee e1 = new employee("Kobe", "Bryant", 20000.0m);
            employee e2 = new employee("Obama", "Bryant", 30000.0m);
            //Show the detail of the employees
            Console.WriteLine("Employee 1");
            Console.WriteLine("\nFirst Name: {0}\nLast Name:{1}\nsalary:{2:C}", e1.firstName, e1.lastName, e1.monSalary);
            Console.WriteLine("\nEmployee 2");
            Console.WriteLine("\nFirst Name: {0}\nLast Name:{1}\nsalary:{2:C}", e2.firstName, e2.lastName, e2.monSalary);
            //raise the salary by 10%
            e1.monSalary += (e1.monSalary * 10) / 100;
            e2.monSalary += (e2.monSalary * 10) / 100;
            //show the detail after increase salary.
            Console.WriteLine("\nEmployee 1");
            Console.WriteLine("\nFirst Name: {0}\nLast Name:{1}\nsalary:{2:C}", e1.firstName, e1.lastName, e1.monSalary);
            Console.WriteLine("\nEmployee 2");
            Console.WriteLine("\nFirst Name: {0}\nLast Name:{1}\nsalary:{2:C}", e2.firstName, e2.lastName, e2.monSalary);
            Console.ReadKey();
        }

    }
}
