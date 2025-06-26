using System;
using System.ComponentModel.Design;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Opening statement
        Console.WriteLine("Welcome to the Goal Activity");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        QuestManager Q = new QuestManager();
       
        int choiceNumber = 1;
        while (choiceNumber != 0)
        {
            Q.SetScore();
            Q.SetLevel();
            Console.WriteLine($"You are level {Q.getLevel} with {Q.getScore} points.");
            Console.WriteLine();
            MainMenu();
            Console.Write("Select a choice from the Menu Options: ");
            string choice = Console.ReadLine();
            choiceNumber = int.Parse(choice);

            switch (choiceNumber)
            {
                case 1: //Create Goal
                    Console.WriteLine("The Types of Goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("What type of goal would you like to create? ");
                    string goal = Console.ReadLine();
                    int goalInt = int.Parse(goal);
                    Q.SetGoal(goalInt);
                    break;

                case 2: //List Goals

                    break;

                case 3: //Save Goals

                    break;

                case 4: //Load Goals

                    break;

                case 5: //Record Event

                    break;

                case 0: //Quit
                    choiceNumber = 0;
                    break;
            }
        }



    }


    public static void MainMenu()
    {
        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("0. Quit");
    }
}