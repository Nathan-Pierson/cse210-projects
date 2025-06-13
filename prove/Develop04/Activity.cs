using System.ComponentModel;
using System.Runtime.CompilerServices;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }


    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }


    /// <summary>
    /// This is a method that will create a countdown for the user to follow.
    /// </summary>
    public void CountDown(string text, int count)
    {
        int i = count;
        while (i != 0)
        {
            Console.Write($"\r{text} {i}");
            Thread.Sleep(1000);
            i -= 1;
        }
        Console.Write("\b \b");
    }


    /// <summary>
    /// This is a method that will create a spinner
    /// </summary>
    public void Spinner(int count)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };

        for (int i = 0; i < count; i++)
        {
            foreach (string s in spinner)
            {
                Console.Write($"\r{s}");
                Thread.Sleep(250);
            }
        }
        Console.Write("\b \b");

    }


    /// <summary>
    /// A simple starting/welcome message that gives them the activity name, description, and asks them how long they want to 
    /// complete this activity for
    /// </summary>
    public void StartMessage()
    {
        //This is simply writing to the console the description.
        Console.Clear();
        Console.WriteLine($"Welcome to the {GetName()}!");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"{GetDescription()}");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.Write("How long, in seconds, would you like this session to be? >>> ");

        //This code sets the duration and in/out duration
        string duration = Console.ReadLine();
        int durationInt = int.Parse(duration);
        SetDuration(durationInt);
    }


    /// <summary>
    /// An end message that is displayed at the end of every activity to congratulate them on their success.
    /// </summary>
    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Spinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have successfully completed another {_duration} seconds of the {_name}!");
        Spinner(5);
    }
}