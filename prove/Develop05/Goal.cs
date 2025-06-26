abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;


    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }


    public string GetName()
    {
        return _name;
    }


    public string GetDescription()
    {
        return _description;
    }


    public int GetPoints()
    {
        return _points;
    }


    public bool GetStatus()
    {
        return _isComplete;
    }


    public void IsComplete()
    {
        _isComplete = true;
    }


    /// <summary>
    /// This is polymorphism that each of the child classes will use to 
    /// display the goals that they have created. 
    /// </summary>
    public abstract void Display();

    public abstract void MarkComplete();
}