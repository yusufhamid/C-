/*
4.11 (Employee Class) Create a class called Employee that includes three pieces of information as either
instance variables or auto-implemented properties—a first name (type string), a last name (type string) 
and a monthly salary (decimal). Your class should have a constructor that initializes the three values.
Provide a property with a get and set accessor for any instance variables. If the monthly salary is negative,
the set accessor should leave the instance variable unchanged. Write a test app named EmployeeTest that 
demonstrates class Employee’s capabilities. Create two Employee objects and display each object’s yearly salary. 
Then give each Employee a 10% raise and display each Employee’s yearly salary again.
*/

using System;
/****Create and test Employee class ****/
namespace p411.cs //define name
{



    public class employee //define class
    {
        //define the variable
        string fName;
        string lName;
        decimal mSalary;
        //define the property for the first name and read the value
        public string firstName
        {
            get { return fName; }// get the first name

            set { fName = value; }// set for the first name
        }
        //define the for last name and read the value
        public string lastName
        {
            get { return lName; }// get the last name
            set { lName = value; }// set for the last name
        }
        //define for monthly salary
        public decimal monSalary
        {
            get { return mSalary; }// get the monthly salary
            set
            {
                if (value >= 0)
                    mSalary = value;
            }//set the monthly salary and the value should greater than zero
        }
        //define the constructor
        public employee(string fname, string lname, decimal msalary)
        {
            fName = fname;
            lName = lname;
            mSalary = msalary;
        }
    }
}

