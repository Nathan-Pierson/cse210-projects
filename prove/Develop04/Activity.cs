using System.ComponentModel;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
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
        Console.Clear();
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
    public void Spinner(int count)
    {
        Console.Clear();
        List<string> spinner = new List<string> { "|", "/", "-", "\\", };

        for (int i = count; i != 5; i++)
        {
            foreach (string s in spinner)
            {
                Console.Write($"\r{s}");
                Thread.Sleep(500);
            }
        }

    }


    public void EndMessage()
    {
        Console.WriteLine("Well Done!");
        Spinner(5);
        Console.WriteLine($"You have successfully completed another {_duration} of the {_name}!");
        Spinner(5);
    }

}