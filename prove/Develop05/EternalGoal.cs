class EternalGoal : Goal
{
    private int _completions;


    public EternalGoal(string name, string description, int points) :
    base(name, description, points)
    {
        _completions = 0;
    }


    public override void Display()
    {
        Console.WriteLine($"[∞] {GetName()} ({GetDescription()}) Completions:{_completions}");
    }

    public override void MarkComplete()
    {
        _completions += 1;
    }

    public override int GetAllPoints()
    {
        return GetPoints() * _completions;
    }
}