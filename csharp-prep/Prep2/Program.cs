using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        int grade = Int32.Parse(Console.ReadLine());
        string letterGrade = "O";

        if (grade > 90)
        {
            letterGrade = "A";
            Console.WriteLine($"Congradulation! You got an {letterGrade}!");
        }
        else if (grade > 80)
        {
            letterGrade = "B";
            Console.WriteLine($"You did really well! You got a {letterGrade}!");
        }
        else if (grade > 70)
        {
            letterGrade = "C";
            Console.WriteLine($"C's get degrees! You got a {letterGrade}!");
        }
        else if (grade > 60)
        {
            letterGrade = "D";
            Console.WriteLine($"It's not failing. You got a {letterGrade}.");
        }
        else
        {
            letterGrade = "F";
            Console.WriteLine($"Oof! You got an {letterGrade}.");
        }
        if (grade > 70)
        {
            Console.WriteLine("Congradulations! You Passed!");
        }
        else
        {
            Console.WriteLine("Oof! Better luck next semester. You didn't pass.");
        }      
        //This will just get a letter grade and then have one print statement at the end.
        if (grade > 90)
        {
            letterGrade = "A";
        }
        else if (grade > 80)
        {
            letterGrade = "B";
        }
        else if (grade > 70)
        {
            letterGrade = "C";
        }
        else if (grade > 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"You got an {letterGrade}!");

    }
}