class ReflectionActivity : Activity
{
    private string _prompt;
    private string _question;
    private Random _random = new Random();
    private List<string> _reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you faced a significant challenge and overcame it.",
        "Describe a moment when you felt truly proud of yourself.",
        "Recall a time when you made a mistake. Consider the impact and what you took away from it.",
        "Think about a person who has significantly influenced your life.",
        "Describe a situation where you had to adapt quickly to unexpected circumstances.",
        "When have you felt a strong sense of gratitude.",
        "Think of a time when you had to make a tough decision.",
        "Recall a time when you felt completely out of your comfort zone.",
        "Describe a moment when you realized something important about yourself.",
        "Think of a time when you had to forgive someone, or be forgiven.",
        "When have you felt a strong connection to nature or the world around you.",
        "Recall a time when you felt a deep sense of peace or contentment.",
        "Think of a time when you used your creativity to solve a problem.",
        "Describe a time when you surprised yourself with your own capabilities.",
        "When have you felt truly inspired.",
        "Think of a time when you learned a valuable lesson outside of a formal educational setting.",
        "Describe a moment when you felt a strong sense of belonging.",
        "Recall a time when you successfully persuaded someone to see your point of view.",
        "Think of a time when you had to prioritize your well-being.",
        "Describe a situation where you had to lead a group or project.",
        "When have you felt a sense of awe or wonder."
    };
    private List<string> _reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "What challenges did you face during this experience, and how did you overcome them?",
        "Who else was involved in this experience, and what was their role?",
        "How did this experience change your perspective on something?",
        "If you could do it again, what would you do differently?",
        "What resources or support did you utilize during this time?",
        "How did this experience align with your values or beliefs?",
        "What impact did this experience have on others, if any?",
        "How did you feel emotionally throughout this experience?",
        "What was the most surprising aspect of this experience?",
        "What steps did you take to achieve your goal or outcome?",
        "How might this experience influence your future actions or decisions?",
        "What strengths did you discover or utilize during this time?",
        "Were there any unexpected outcomes, positive or negative?",
        "How did you celebrate or acknowledge the completion of this experience?",
        "What advice would you give to someone embarking on a similar experience?",
        "How has this experience contributed to your personal growth?"
    };


    public ReflectionActivity(string name, string description) : base(name, description)
    {
        string prompt = GetRandomPrompt();
        string question = GetRandomQuestion();
        _prompt = prompt;
        _question = question;

    }


    /// <summary>
    /// This is the main method that will run the entire Reflection Activity
    /// It will print to the console and engage with the user.
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

        //Thinking on the prompt
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---{_prompt}---");
        Console.Write("When you have had sufficient time to ponder hit enter.");
        Console.ReadLine();

        //The follow up question that they should ponder on
        Console.WriteLine("Ponder on each of these following questions and how they related to this experience.");
        CountDown("You may begin in: ", 5);
        Console.Clear();

        //Required variables for the activity while loop.
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;

        //While loop that will keep giving pondering question until the duration is over.
        while (currentTime < futureTime)
        {
            Console.WriteLine($">{_question}");
            Spinner(10);
            string anotherQuestion = GetRandomQuestion();
            _question = anotherQuestion;
            currentTime = DateTime.Now;
        }
    }




    /// <summary>
    /// Returns a random reflection prompt from the list.
    /// </summary>
    public string GetRandomPrompt()
    {
        int i = _random.Next(_reflectionPrompts.Count);
        return _reflectionPrompts[i];
    }


    /// <summary>
    /// Returns a random reflection question from the list.
    /// </summary>
    public string GetRandomQuestion()
    {
        int i = _random.Next(_reflectionQuestions.Count);
        return _reflectionQuestions[i];
    }
}