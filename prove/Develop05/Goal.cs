abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private int _numberGoal;
    private bool _isComplete;


    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _numberGoal = 0;
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


    public int GetNumberGoal()
    {
        return _numberGoal;
    }


    public void SetNumberGoal(int number)
    {
        _numberGoal = number;
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


    /// <summary>
    /// A polymorphic method that is used to set a goal as completed
    /// </summary>
    public abstract void MarkComplete();


    /// <summary>
    /// A polymorphic method used to calculate all points acquired from each completion.
    /// </summary>
    public abstract int GetAllPoints();
}