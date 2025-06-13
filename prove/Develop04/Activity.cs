using System.ComponentModel;
using System.Runtime.CompilerServices;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    /// <summary>
    /// Constructor for the Activity class
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }


    /// <summary>
    /// A setter for the duration
    /// </summary>
    /// <param name="duration"></param>
    public void SetDuration(int duration)
    {
        _duration = duration;
    }


    /// <summary>
    /// Getter for _name
    /// </summary>
    /// <returns> _name </returns>
    public string GetName()
    {
        return _name;
    }


    /// <summary>
    /// Getter for Description
    /// </summary>
    /// <returns> _description </returns>
    public string GetDescription()
    {
        return _description;
    }


    /// <summary>
    /// Getter for Duration
    /// </summary>
    /// <returns> _duration </returns>
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


    /// <summary>
    /// A simple method that will repeat the activity with the same prompt, but give them more time to breath, list items, or reflect.
    /// </summary>
    public void Repeat(Run x)
    {
        Console.WriteLine();
        Console.WriteLine("Would you like more time? (Y/N) >>> ");
        string answer = Console.ReadLine();

        while (true)
        {
            if (answer == "Y" || answer == "y")
            {
                x.Run();

                break;
            }
            else if (answer == "N" || answer == "n")
            {
                break;
            }
            else { Console.WriteLine("Please choose an available option."); }
        }
    }
}