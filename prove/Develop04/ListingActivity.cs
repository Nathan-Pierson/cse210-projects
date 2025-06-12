using System.Globalization;

class ListingActivity : Activity
{
    private string _prompt;
    private List<string> _items;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are moments you felt proud of yourself?",
        "Who has made a positive impact on your life?",
        "What are things you're grateful for today?",
        "When have you felt God's love recently?",
        "What are talents you've been blessed with?",
        "Who are people you look up to and why?",
        "What are acts of service you've witnessed?",
        "When have you felt peace in your heart?",
        "What are lessons you've learned from challenges?",
        "Who are family members you're grateful for?",
        "What are ways you've grown this year?",
        "When have you felt guided by inspiration?",
        "What are things that bring you joy?",
        "Who are friends that lift you up?",
        "What are moments when you felt God's hand in your life?",
        "What are ways you've been a good example?",
        "Who are people you've forgiven?",
        "What are prayers that have been answered?",
        "When have you felt the Spirit testify of truth?",
        "What are ways you've served others?",
        "Who are teachers that have influenced you?",
        "What are scriptures that have comforted you?",
        "When have you felt hope during difficult times?",
        "What are ways you've shown kindness?",
        "Who are people you want to be more like?"
    };


    /// <summary>
    /// This is the constructor for the Listing Activity.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="duration"></param>
    public ListingActivity(string name, string description) : base(name, description)
    {
        string randomPrompt = GetRandomPrompt();
        _prompt = randomPrompt;
        _items = new List<string>();
    }


    /// <summary>
    /// This method will run the entire listing activity.
    /// It will print everything to the console that is required for
    /// the user to follow along with the listing exercises. 
    /// </summary>
    public void Run()
    {
        //Reads the activity description to the console.
        Console.Clear();
        Console.WriteLine($"Welcome to the {GetName()}!");
        Console.WriteLine($"{GetDescription()}");

        //Gets the Duration for the activity
        Console.Write("How long, in seconds, would you like this session to be? ");
        string duration = Console.ReadLine();
        int durationInt = int.Parse(duration);
        SetDuration(durationInt);

        //Prompt for the user to see at the top of the console
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner(6);
        Console.WriteLine(_prompt);
        CountDown("You may begin in: ", 5);
        Console.WriteLine();

        //Required variables for the activity while loop.
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;

        //While loop that lets the user continue to add things to a list until the time runs out.
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            _items.Add(item);
            currentTime = DateTime.Now;
        }

        //The list of how many items they wrote down.
        int numberOfItems = _items.Count();
        Console.WriteLine($"Congratulations! You listed {numberOfItems} items!");
    }

    /// <summary>
    /// This is a quick method that returns a random prompt that 
    /// is saved to the attribute of the class. The prompt will then be
    /// used later in the program.
    /// </summary>
    /// <returns> string </returns>
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }
}