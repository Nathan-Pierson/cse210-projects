class QuestManager
{
    private List<EternalGoal> _eternalGoals = new List<EternalGoal>();
    private List<SimpleGoal> _simpleGoals = new List<SimpleGoal>();
    private List<ChecklistGoal> _checklistGoals = new List<ChecklistGoal>();
    private int _score;
    private int _level;
    private string _levelName;


    public QuestManager()
    {
        _score = 0;
        _level = 0;
        _levelName = "Premortal Spirit";
    }


    /// <summary>
    /// This method will create an object for the new goal that people
    /// want. 
    /// </summary>
    /// <param name="type"> int </param>
    /// 
    string name, description, points;
    int pointsInt;
    public void SetGoal(int type)
    {
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
        switch (type)
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
                    Console.WriteLine("How many times does this goal need to be completed for a bonus?");
                    Console.Write(">");
                    string amountOfCompletions = Console.ReadLine();
                    int amountOfCompletionsInt = int.Parse(amountOfCompletions);
                    Console.WriteLine("What is the bonus for accomplishing it that many times?");
                    Console.Write(">");
                    String bonusPoints = Console.ReadLine();
                    int bonusPointInt = int.Parse(bonusPoints);

                    ChecklistGoal C = new ChecklistGoal(name, description, pointsInt, bonusPointInt, amountOfCompletionsInt);
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
        if (_checklistGoals == null && _eternalGoals == null && _simpleGoals == null)
        {
            _score = 0;
        }
        else
        {
            foreach (SimpleGoal s in _simpleGoals)
            {
                _score += s.GetPoints();
            }

            foreach (EternalGoal e in _eternalGoals)
            {
                _score += e.GetPoints();
            }

            foreach (ChecklistGoal c in _checklistGoals)
            {
                _score += c.GetPoints();
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
            _levelName = "Premortal Spirit";
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
    public int getScore()
    {
        return _score;
    }


    /// <summary>
    /// Returns the level the player is at.
    /// </summary>
    /// <returns> int </returns>
    public int getLevel()
    {
        return _level;
    }
    /// <summary>
    /// This method will save all of your goals onto a file
    /// </summary>
    public void SaveProgress()
    {

    }


    /// <summary>
    /// This method will read a file and load all of the goals back 
    /// into the attributes so it can be used again.
    /// </summary>
    public void LoadProgress()
    {

    }


    /// <summary>
    /// This method will list all the goals that you have ever written.
    /// First is eternal, then checklist, then simple.
    /// </summary>
    public void ListGoals()
    {
        
    }


    /// <summary>
    /// This method is used to report the completion of certain goals
    /// </summary>
    public void ReportGoals()
    {

    }
}