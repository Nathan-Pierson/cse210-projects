using System.ComponentModel;

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
    }


    /// <summary>
    /// This is a method that will create a spinner
    /// </summary>
    public void Spinner()
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };

        for (int i = 0; i < 5; i++)
        {
            foreach (string s in spinner)
            {
                Console.Write($"\r{s}");
                Thread.Sleep(250);
            }
        }
        Console.Write("\b \b");

    }


    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Spinner();
        Console.WriteLine();
        Console.WriteLine($"You have successfully completed another {_duration} seconds of the {_name}!");
        Spinner();
    }

}