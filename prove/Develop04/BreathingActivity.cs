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
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
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
        Console.Clear();
        Console.WriteLine($"Welcome to the {GetName()}!\n{GetDescription()}\nYou will complete this activity for {GetDuration()} seconds.");
        Thread.Sleep(10000);
        CountDown("Begin Breathing Activity in", 5);
        while (_inDuration != 0 && _outDuration != 0)
        {
            CountDown("Breath in", 4);
            _inDuration -= 1;
            CountDown("Breath Out", 4);
            _outDuration -= 1;
        }
    }
}