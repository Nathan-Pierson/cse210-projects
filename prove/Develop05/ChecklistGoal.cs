class ChecklistGoal : Goal
{
    private int _completions;
    private int _amountOfCompletions;
    private int _bonusPoints;


    public ChecklistGoal(string name, string description, int points, int bonusPoints, int amountOfCompletions) :
    base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _amountOfCompletions = amountOfCompletions;
        _completions = 0;
    }


    public void SetCompletions(int completions)
    {
        _completions = completions;
    }

    public int GetCompletions() { return _completions; }

    public int GetAmountOfCompletions(){return _amountOfCompletions;}

    public int GetBonusPoints(){return _bonusPoints;}


    public override void Display()
    {
        if (_completions == _amountOfCompletions)
        {
            Console.WriteLine($"[x] {GetName()} ({GetDescription()}) Currently Completed {_completions}/{_amountOfCompletions}");
        }

        else
        {
            Console.WriteLine($"[ ] {GetName()} ({GetDescription()}) -- Currently Completed: {_completions}/{_amountOfCompletions}");
        }
    }

    public override void MarkComplete()
    {
        _completions += 1;
        if (_completions == _amountOfCompletions)
        {
            IsComplete();
        }
    }

    public override int GetAllPoints()
    {
        int points = 0;
        if (_completions == _amountOfCompletions)
        {
            points = (GetPoints() * _completions) + _bonusPoints;
        }
        else
        {
            points = GetPoints() * _completions;
        }

        return points;
    }
}