class BreathingActivity : Activity
{
    private int _inDuration;
    private int _outDuration;


    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        int numberOfTimes = duration / 2; //A given amount of how many times they will breath in and breath out.
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

    }
}