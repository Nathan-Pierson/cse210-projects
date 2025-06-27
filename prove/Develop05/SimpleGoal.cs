class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) :
    base(name, description, points)
    { }


    public override void Display()
    {
        if (GetStatus() == true)
        {
            Console.WriteLine($"[x] {GetName()} ({GetDescription()})");
        }

        else
        {
            Console.WriteLine($"[ ] {GetName()} ({GetDescription()})");
        }
    }

    public override void MarkComplete()
    {
        IsComplete();
    }


    public override int GetAllPoints()
    {
        return GetPoints();
    }
}