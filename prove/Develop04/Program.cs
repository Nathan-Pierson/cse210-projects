using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Net.Quic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program!\n");
        int quit = 0;

        //The main loop that is used for the menu and the entire program
        while (quit == 0)
        {
            Menu();
            string choice = Console.ReadLine();
            int choiceInt = int.Parse(choice);

            //The main switch that goes through the users option and gives the correct activity
            //for the option that the user choose.
            switch (choiceInt)
            {
                case 1: //Breathing Activity
                    string description = "This activity will help you relax by guiding you through breathing in and out slowly. \nDrown out all distractions and focus on your breathing.";
                    BreathingActivity b = new BreathingActivity("Breathing Activity", description);
                    b.Run();
                    b.EndMessage();
                    break;
                case 2: //Listing Activity
                    description = "This activity will help you reflect on the many wonderful things in your life by having you list as \nmany things as you can about a certain topic.";
                    ListingActivity l = new ListingActivity("Listing Activity", description);
                    l.Run();
                    l.EndMessage();
                    break;
                case 3: //Reflection Activity
                    description = "This activity will help you reflect on times in your life when you have overcome trials. It will help you better \nrecognize your strength and how you can use it in more aspects of your life.";
                    ReflectionActivity r = new ReflectionActivity("Reflection Activity", description);
                    r.Run();
                    r.EndMessage();
                    break;
                case 4: //quit
                    quit = 1;
                    break;
            }
        }
    }


    /// <summary>
    /// The main menu console
    /// </summary>
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Here are some Helpful Activity Options!\n");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflection Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Please pick an option (1-4) >>> ");
    }
}


/// <summary>
/// An interface that is used to call all of the programs over again
/// </summary>
public interface Run
{
    void Run();
}