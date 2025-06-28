using System.IO;

class QuestManager
{
    private List<EternalGoal> _eternalGoals = new List<EternalGoal>();
    private List<SimpleGoal> _simpleGoals = new List<SimpleGoal>();
    private List<ChecklistGoal> _checklistGoals = new List<ChecklistGoal>();
    private int _score; //The total score that the user has acquired
    private int _level; //The level of the user
    private string _levelName; //The level name of the user.


    public QuestManager()
    {
        _score = 0;
        _level = 0;
        _levelName = "Premortal";
    }


    /// <summary>
    /// This method will create an object for the new goal that people
    /// want. 
    /// </summary>
    /// <param name="type"> int </param>
    public void SetGoal()
    {
        ///This is the lines of code asking the user for the type of goal
        /// that they want to create
        Console.WriteLine("The Types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        string goal = Console.ReadLine();
        int goalInt = int.Parse(goal);


        ///This is asking the user for the name of the goal
        /// its descriptions and also for the amount of points
        /// that they will receive each time they complete the goal.
        Console.WriteLine("What is the Name of your goal?");
        Console.Write(">");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal?");
        Console.Write(">");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        Console.Write(">");
        string points = Console.ReadLine();
        int pointsInt = int.Parse(points);


        ///The switch that will create each type of goal that the user 
        /// wants to create. I like switches a lot.
        switch (goalInt)
        {
            case 1: //Simple Goal
                {
                    SimpleGoal S = new SimpleGoal(name, description, pointsInt); //Creates the new simple goal object
                    _simpleGoals.Add(S); //Adds the new simple goal to the list of simple goals.
                }
                break;

            case 2: //Eternal Goal
                {
                    EternalGoal E = new EternalGoal(name, description, pointsInt);
                    _eternalGoals.Add(E);
                }
                break;

            case 3: //Checklist Goal
                {
                    ///Asking the user for bonus points and for how many completions
                    /// needed to receive those bonus points.
                    Console.WriteLine("How many times does this goal need to be completed for a bonus?");
                    Console.Write(">");
                    string amountOfCompletions = Console.ReadLine();
                    int amountOfCompletionsInt = int.Parse(amountOfCompletions);
                    Console.WriteLine("What is the bonus for accomplishing it that many times?");
                    Console.Write(">");
                    String bonusPoints = Console.ReadLine();
                    int bonusPointInt = int.Parse(bonusPoints);

                    //Creating the new goal
                    ChecklistGoal C = new ChecklistGoal(name, description, pointsInt, bonusPointInt, amountOfCompletionsInt);
                    _checklistGoals.Add(C);
                }
                break;
        }

    }


    /// <summary>
    /// This method will go through the lists of goals and check to
    /// see if any of the goals have been completed. every time it finds
    /// a goal that has been completed it will add the points to the
    /// _score.
    /// </summary>
    public void SetScore()
    {
        _score = 0;
        if (_checklistGoals == null && _eternalGoals == null && _simpleGoals == null)
        {
            _score = 0;
        }
        else
        {
            foreach (SimpleGoal s in _simpleGoals)
            {
                _score += s.GetAllPoints();
            }

            foreach (EternalGoal e in _eternalGoals)
            {
                _score += e.GetAllPoints();
            }

            foreach (ChecklistGoal c in _checklistGoals)
            {
                _score += c.GetAllPoints();
            }
        }
    }


    /// <summary>
    /// This method will look at the _score to see how many points you
    /// have acquired and will then determine what level you will be
    /// assigned. 
    /// </summary>
    public void SetLevel()
    {
        if (_score < 100)
        {
            _level = 0;
            _levelName = "Premortal";
        }
        else if (_score < 300)
        {
            _level = 1;
            _levelName = "Telestial";
        }
        else if (_score < 600)
        {
            _level = 2;
            _levelName = "Terrestrial";
        }
        else if (_score < 1000)
        {
            _level = 3;
            _levelName = "Celestial";
        }
        else
        {
            _level = 4;
            _levelName = "Exalted";
        }
    }


    /// <summary>
    /// Returns the score the player has achieved.
    /// </summary>
    /// <returns> int </returns>
    public int GetScore()
    {
        return _score;
    }


    /// <summary>
    /// Returns the level the player is at.
    /// </summary>
    /// <returns> int </returns>
    public int GetLevel()
    {
        return _level;
    }


    /// <summary>
    /// returns level name
    /// </summary>
    /// <returns> string </returns>
    public string GetLevelName()
    {
        return _levelName;
    }


/// <summary>
/// This method will save all of your goals onto a file
/// </summary>
public void SaveGoals()
{
    Console.Clear();
    Console.WriteLine("What do you want to name the file?");
    Console.Write(">");
    string fileName = Console.ReadLine();
    
    using (StreamWriter writer = new StreamWriter(fileName))
    {
        // Save the current score and level first
        writer.WriteLine($"Score:{_score}");
        writer.WriteLine($"Level:{_level}");
        writer.WriteLine($"LevelName:{_levelName}");
        
        // Save Eternal Goals
        if (_eternalGoals != null)
        {
            foreach (EternalGoal goal in _eternalGoals)
            {
                writer.WriteLine(TheFactoryPattern(goal));
            }
        }
        
        // Save Simple Goals
        if (_simpleGoals != null)
        {
            foreach (SimpleGoal goal in _simpleGoals)
            {
                writer.WriteLine(TheFactoryPattern(goal));
            }
        }
        
        // Save Checklist Goals
        if (_checklistGoals != null)
        {
            foreach (ChecklistGoal goal in _checklistGoals)
            {
                writer.WriteLine(TheFactoryPattern(goal));
            }
        }
    }
        
        Console.WriteLine($"Goals successfully saved to {fileName}!");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
}

/// <summary>
/// A simple method that will take all of the objects and turn them into 
/// useable strings that can be saved to a file for future use.
/// </summary>
public string TheFactoryPattern(object stuff)
{
    if (stuff is EternalGoal eternalGoal)
    {
        return $"EternalGoal:{eternalGoal.GetName()}|{eternalGoal.GetDescription()}|{eternalGoal.GetPoints()}|{eternalGoal.GetCompletions()}";
    }
    else if (stuff is SimpleGoal simpleGoal)
    {
        return $"SimpleGoal:{simpleGoal.GetName()}|{simpleGoal.GetDescription()}|{simpleGoal.GetPoints()}|{simpleGoal.GetStatus()}";
    }
    else if (stuff is ChecklistGoal checklistGoal)
    {
        return $"ChecklistGoal:{checklistGoal.GetName()}|{checklistGoal.GetDescription()}|{checklistGoal.GetPoints()}|{checklistGoal.GetCompletions()}|{checklistGoal.GetAmountOfCompletions()}|{checklistGoal.GetBonusPoints()}";
    }
    else
    {
        return "Unknown goal type";
    }
}


/// <summary>
/// This method will read a file and load all of the goals back 
/// into the attributes so it can be used again.
/// </summary>
public void LoadGoals()
{
    Console.Clear();
    Console.WriteLine("What is the name of the file you want to load?");
    Console.Write(">");
    string fileName = Console.ReadLine();
    
    try
    {
        // Initialize lists to ensure they're not null
        _eternalGoals = new List<EternalGoal>();
        _simpleGoals = new List<SimpleGoal>();
        _checklistGoals = new List<ChecklistGoal>();
        
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // This will set the score, level, and level name.
                if (line.StartsWith("Score:"))
                {
                    _score = int.Parse(line.Substring(6));
                }
                else if (line.StartsWith("Level:"))
                {
                    _level = int.Parse(line.Substring(6));
                }
                else if (line.StartsWith("LevelName:"))
                {
                    _levelName = line.Substring(10);
                }
                // This will make the eternal goal objects.
                else if (line.StartsWith("EternalGoal:"))
                {
                    string data = line.Substring(12); //Removes the heading "EternalGoal:"
                    string[] parts = data.Split('|');
                    
                    EternalGoal goal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
                    goal.SetCompletions(int.Parse(parts[3]));
                    _eternalGoals.Add(goal);
                }
                // This is loading all of the simple goals
                else if (line.StartsWith("SimpleGoal:"))
                {
                    string data = line.Substring(11); // removes the heading "SimpleGoal :"
                    string[] parts = data.Split('|');
                    
                    SimpleGoal goal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));
                    bool isComplete = bool.Parse(parts[3]);
                    if (isComplete == true){ goal.IsComplete(); }
                    _simpleGoals.Add(goal);
                }
                // This is for loading all of the checklist goals
                else if (line.StartsWith("ChecklistGoal:"))
                {
                    string data = line.Substring(14);//Removes the heading "ChecklistGoal :"
                    string[] parts = data.Split('|');
                    
                    ChecklistGoal goal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), 
                                                         int.Parse(parts[5]), int.Parse(parts[4]));
                    goal.SetCompletions(int.Parse(parts[3]));
                    _checklistGoals.Add(goal);
                }
            }
        }
        
        Console.WriteLine($"Goals successfully loaded from {fileName}!");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine($"File '{fileName}' not found!");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
    }
}


    /// <summary>
    /// This method will list all the goals that you have ever written.
    /// First is eternal, then checklist, then simple.
    /// </summary>
    public void ListGoals()
    {
        Console.Clear();
        if (_checklistGoals.Count() == 0 && _eternalGoals.Count() == 0 && _simpleGoals.Count() == 0)
        {
            Console.WriteLine("There have been no goals made! Please choose the option to make new goals.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        else
        {
            int counter = 1;

            if (_eternalGoals.Count() != 0) { Console.WriteLine("Eternal Goals:"); }
            foreach (EternalGoal e in _eternalGoals)
            {
                Console.Write($"{counter}. ");
                e.Display();
                counter++;
            }
            if (_simpleGoals.Count() != 0) { Console.WriteLine("Simple Goals:"); }
            foreach (SimpleGoal s in _simpleGoals)
            {
                Console.Write($"{counter}. ");
                s.Display();
                counter++;
            }
            if (_checklistGoals.Count() != 0) { Console.WriteLine("Checklist Goals:"); }
            foreach (ChecklistGoal c in _checklistGoals)
            {
                Console.Write($"{counter}. ");
                c.Display();
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }


    /// <summary>
    /// This method is used to report the completion of certain goals
    /// </summary>
    public void ReportGoals()
    {
        Console.Clear();
        if (_checklistGoals.Count() == 0 && _eternalGoals.Count() == 0 && _simpleGoals.Count() == 0)
        {
            Console.WriteLine("There have been no goals made! Please choose the option to make new goals.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        else
        {
            int counter = 1;

            if (_eternalGoals.Count() != 0) { Console.WriteLine("Eternal Goals:"); }
            foreach (EternalGoal e in _eternalGoals)
            {
                Console.Write($"{counter}. ");
                e.SetNumberGoal(counter);
                Console.WriteLine(e.GetName());
                counter++;
            }
            if (_simpleGoals.Count() != 0) { Console.WriteLine("Simple Goals:"); }
            foreach (SimpleGoal s in _simpleGoals)
            {
                Console.Write($"{counter}. ");
                s.SetNumberGoal(counter);
                Console.WriteLine(s.GetName());
                counter++;
            }
            if (_checklistGoals.Count() != 0) { Console.WriteLine("Checklist Goals:"); }
            foreach (ChecklistGoal c in _checklistGoals)
            {
                Console.Write($"{counter}. ");
                c.SetNumberGoal(counter);
                Console.WriteLine(c.GetName());
                counter++;
            }
            Console.WriteLine("Which goal did you Accomplish?");
            Console.Write(">");
            string goalAccomplished = Console.ReadLine();
            int goalAccomplishedInt = int.Parse(goalAccomplished);

            foreach (EternalGoal e in _eternalGoals)
            {
                if (e.GetNumberGoal() == goalAccomplishedInt) { e.MarkComplete(); }
            }
            foreach (SimpleGoal s in _simpleGoals)
            {
                if (s.GetNumberGoal() == goalAccomplishedInt) { s.MarkComplete(); }
            }
            foreach (ChecklistGoal c in _checklistGoals)
            {
                if (c.GetNumberGoal() == goalAccomplishedInt) { c.MarkComplete(); }
            }
        }
    }
}