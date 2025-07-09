class ProRatedPurchase : Purchase
{
    private int _timesPerYear;

    public ProRatedPurchase(string item, float cost, int amount, string date, int times) : base(item, cost, amount, date)
    {
        _timesPerYear = times;
    }

    public int GetTimesPerYear()
    {
        return _timesPerYear;
    }


    public override void Display()
    {
        Console.WriteLine();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Item: {GetItem()}");
        Console.WriteLine($"Cost: ${GetCost()}");
        Console.WriteLine($"Times Per Year: {_timesPerYear}");
    }
}