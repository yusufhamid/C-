/*
7.39 (Computer-Assisted Instruction) The use of computers in education is referred to as computer-assisted instruction (CAI).
Write a program that will help an elementary-school student learn multiplication. Use a Random object to produce two positive 
one-digit integers. The program should then prompt the user with a question, such as
                How much is 6 times 7?
The student then inputs the answer. Next, the program checks the student’s answer. If it’s correct,
display the message "Very good!" and ask another multiplication question. If the answer is wrong,
display the message "No. Please try again." and let the student try the same question repeatedly 
until the student gets it right. A separate method should be used to generate each new question. 
This method should be called once when the app begins execution and each time the user answers 
the question correctly.
*/

using System;


namespace CAI
{
    class Program
    {


        static void Main(string[] args)
        {
            // Picks random number
            Random rnd = new Random();
            int rndnumber1 = rnd.Next(10);
            //picks second random number
            int rndnumber2 = rnd.Next(10);
            int x;
            //displays the random  numbers
            Console.WriteLine(rndnumber1);
            Console.WriteLine(rndnumber2);

            Console.WriteLine($"how much is " + rndnumber1 + " times " + rndnumber2);

            x = int.Parse(Console.ReadLine()); //reads the users answer


            //runs until the x= the correct answer
            while (x != rndnumber1 * rndnumber2)
            {

                Console.WriteLine("no, please try again");
                Console.WriteLine($"how much is " + rndnumber1 + " times " + rndnumber2);
                // Console.ReadLine();
                x = int.Parse(Console.ReadLine());
                //Console.ReadLine();
            }
            if (x == rndnumber1 * rndnumber2) //indicates stop
            {
                Console.WriteLine("very good");
                Console.ReadLine();
            }
        }
    }
}
