

/*
Assignment 1
Write a simple code to grade students score for a test.

Note:
70 - 100 = A
60 - 69 = B
50 - 59 = C
40 - 49 = D

0 - 39 = F
 */

// string Firstname;
// string Lastname;
// String FullName = ($"{ Firstname } + {Lastname}");
using System;

namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello..., you are here for your grade. Don't Panic!"); // Greetings

            /* Console.WriteLine("Please input your firstname: ");
            string firstname = Console.ReadLine().ToLower();

            Console.WriteLine("Please input your lastname: ");
            string lastname = Console.ReadLine().ToLower();

            string fullName = firstname + "  " + lastname; 

            Console.WriteLine($"Hello  {fullName}");
            */

            Console.WriteLine("Kindly enter the student's score (0-100)"); //prompt the enter students's score 
            int score = Convert.ToInt32(Console.ReadLine());


            //    public string Grade;
            if (score >= 70 && score <= 100)
            {
                Console.WriteLine("A");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("B");
            }
            else if (score >= 50 && score <= 59)
            {
                Console.WriteLine("C");
            }
            else if (score >= 40 && score <= 49)
            {
                Console.WriteLine("D");
            }
            else if (score >= 0 && score <= 39)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Enter the correct score");
            }
        }
    }
}