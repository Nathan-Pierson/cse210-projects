using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Opening statement
        Console.Clear();
        Console.WriteLine("Welcome to the Goal Activity");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        QuestManager Q = new QuestManager();
       
        int choiceNumber = 1;
        while (choiceNumber != 0)
        {
            Console.Clear();
            Q.SetScore();
            Q.SetLevel();
            Console.WriteLine($"You are 'A {Q.GetLevelName()} Being' at level {Q.GetLevel()} with {Q.GetScore()} points.");
            Console.WriteLine($"You need {Q.GetPointsToNextLevel()} points to reach the next level!");
            Console.WriteLine();
            MainMenu();
            Console.Write("Select a choice from the Menu Options: ");
            string choice = Console.ReadLine();
            choiceNumber = int.Parse(choice);

            switch (choiceNumber)
            {
                case 1: //Create Goal
                    Q.SetGoal();
                    break;

                case 2: //List Goals
                    Q.ListGoals();
                    break;

                case 3: //Save Goals
                    Q.SaveGoals();
                    break;

                case 4: //Load Goals
                    Q.LoadGoals();
                    break;

                case 5: //Record Event
                    Q.ReportGoals();
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