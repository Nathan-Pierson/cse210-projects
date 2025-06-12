class BreathingActivity : Activity
{
    private int _inDuration;
    private int _outDuration;


    /// <summary>
    /// This is the constructor for the BreathingActivity.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="duration"></param>
    public BreathingActivity(string name, string description) : base(name, description)
    {
        _inDuration = 0;
        _outDuration = 0;
    }


    public void SetInOutDuration(int duration)
    {
        int numberOfSecondsPerBreath = duration / 2; //A given amount of how many times they will breath in and breath out.
        int numberOfTimes = numberOfSecondsPerBreath / 4;
        _inDuration = numberOfTimes;
        _outDuration = numberOfTimes;
    }


    /// <summary>
    /// This method will run the entire breathing exercise and print
    /// things into the console to help the user follow the entire
    /// breathing exercise.
    /// </summary>
    public void Run()
    {
        //This is simply writing to the console the description.
        Console.Clear();
        Console.WriteLine($"Welcome to the {GetName()}!");
        Console.WriteLine($"{GetDescription()}");
        Console.Write("How long, in seconds, would you like this session to be? ");

        //This code sets the duration and in/out duration
        string duration = Console.ReadLine();
        int durationInt = int.Parse(duration);
        SetDuration(durationInt);
        SetInOutDuration(durationInt);

        //This finally begins the breathing activity.
        Console.Clear();
        Console.WriteLine($"You will complete this activity for {GetDuration()} seconds.");
        Console.Clear();
        Console.WriteLine("Get ready... ");
        Spinner(6);

        //This is the main loop of the activity that helps you breath in and out.
        while (_inDuration != 0 && _outDuration != 0)
        {
            Console.WriteLine("\n");
            CountDown("Breath in", 4);
            _inDuration -= 1;
            Console.WriteLine();
            CountDown("Breath Out", 4);
            _outDuration -= 1;
        }
    }
}