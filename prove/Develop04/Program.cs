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
        while (quit == 0)
        {
            Menu();
            string choice = Console.ReadLine();
            int choiceInt = int.Parse(choice);

            switch (choiceInt)
            {
                case 1:
                    Console.WriteLine("How long, in seconds, would you like this session to be? ");
                    string duration = Console.ReadLine();
                    int durationInt = int.Parse(duration);
                    string description = "This activity will help you relax by guiding you through breathing in and out slowly. Drown out all distractions and focus on your breathing.";
                    BreathingActivity b = new BreathingActivity("Breathing Activity", description, durationInt);
                    b.Run();
                    break;
                case 2:
                    Console.WriteLine("How long, in seconds, would you like this session to be? ");
                    duration = Console.ReadLine();
                    durationInt = int.Parse(duration);
                    description = "This activity will help you reflect on the many wonderful things in your life by having you list as many things as you can about a certain topic.";
                    ListingActivity l = new ListingActivity("Listing Activity", description, durationInt);
                    l.Run();
                    break;
                case 3:
                    Console.WriteLine("How long, in seconds, would you like this session to be? ");
                    duration = Console.ReadLine();
                    durationInt = int.Parse(duration);
                    description = "This activity will help you reflect on times in your life when you have overcome trials. It will help you better recognize your strength and how you can use it in more aspects of your life.";
                    ReflectionActivity r = new ReflectionActivity("Reflection Activity", description, durationInt);
                    r.Run();
                    break;
            }

            Console.WriteLine("Would you like to do another activity? (Y/N) >>> ");
            string decision = Console.ReadLine();
            if (decision == "Y" || decision == "y") {quit = 0;}
            else { quit = 1;}
        }

    }


    public static void Menu()
    {
        Console.WriteLine("Here are some Helpful Activity Options!\n");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflection Activity");
        Console.WriteLine("Please pick an option (1-3)>>> ");
    }
}