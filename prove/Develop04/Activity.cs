using System.ComponentModel;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }


    public string GetName()
    {
        return _name;
    }


    public string GetDescription()
    {
        return _description;
    }


    public int GetDuration()
    {
        return _duration;
    }


    /// <summary>
    /// This is a method that will create a countdown for the user to follow.
    /// </summary>
    /// <returns> string </returns>
    public string CountDown()
    {
        string count = "";
        return count;
    }


    /// <summary>
    /// This is a method that will create a spinner
    /// </summary>
    /// <returns> string</returns>
    public string Spinner()
    {
        string spin = "";
        return spin;
    }

}