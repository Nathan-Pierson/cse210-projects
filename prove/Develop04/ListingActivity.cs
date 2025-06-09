class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;


    public ListingActivity(string name, string description, int duration, List<string> prompts, List<string> items) : base(name, description, duration)
    {
        _prompts = prompts;
        _items = items;
    }


    /// <summary>
    /// This method will run the entire listing activity.
    /// It will print everything to the console that is required for
    /// the user to follow along with the listing exercises. 
    /// </summary>
    public void Run()
    {

    }
}