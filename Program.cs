using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string name; //name variable declaration
            int n; //int variable declaration
            string s; //string variable declaration
            bool b = false; //boolean variable declaration

            Console.WriteLine("Hello! What is your first name?");
            name = Console.ReadLine();

            
             //Ask user for number between 1 and 10
            Console.WriteLine("Please enter a number between 1 and 10");
            n = int.Parse(Console.ReadLine()); //reads user input

            while (n < 1 || n > 10)
            {
                Console.WriteLine("Learn to follow instructions. Try again.");
                n = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("you entered: {0}", n);
                Console.WriteLine(); //spacing out the lines
              

            
            //Ask user for a maximum of three word phrase
            Console.WriteLine("Please enter a three or fewer word phrase.");
            s = Console.ReadLine();
            int countSpaces = s.Count(char.IsWhiteSpace);
            int spaces = countSpaces;

                while (spaces > 2)
                {
                    Console.WriteLine("You entered more than three words! Try again!");
                    s = Console.ReadLine();
                    spaces = s.Count(char.IsWhiteSpace);
                }
                Console.WriteLine("You gave the phrase: {0}!", s);
                Console.WriteLine(); //spacing out lines
            

            int x; //initialize the two numbers to be checked
            int y;
 
            //initialize and retrieve bool check for two numbers
            Console.WriteLine("The following will check if the second number is greater than the first.");
            Console.WriteLine("Please enter first number.");
            x = int.Parse(Console.ReadLine()); //read first number from user

            Console.WriteLine("Your first number is {0}", x);
            Console.WriteLine();

            Console.WriteLine("Please enter second number.");
            y = int.Parse(Console.ReadLine()); //read second number from user

            Console.WriteLine("Your second number is {0}", y);

            string str;
            b = x < y;
            if (b == true)
            {
                str = " ";
            }
            else 
                str = " not ";
 
            Console.Clear();

            Console.WriteLine("Your single digit number was {0}.", n);
            Console.WriteLine();

            Console.WriteLine("Your phrase is: {0}!", s);
            Console.WriteLine();

            Console.WriteLine("The first number you entered was {0} while the second was {1}.", x, y);
            Console.WriteLine("The second number you entered is{0}greater than the first.", str);
            Console.WriteLine();

            Console.WriteLine("Thanks for helping me test out my simple program, {0}! Have a great day!", name);
            Console.ReadLine();
        }
    } 
}

//create program that asks a user for an int and string as well as checking if a statement is true/false

//for the int, check if the number is between 1 and 10, if not, return an error and loop it until user
//enters number between 1 and 10.
//for the string, ask the user  for a 3 or less word phrase and check if phrase is 3 or fewer words
//if so, output phrase, if not loop it until it meets criteria
//for the bool, ask user to put in two digits and check if the second is greater than the first
//if not, return false, otherwise return true
