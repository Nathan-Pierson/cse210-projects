class MiscellaneousPurchase : Purchase
{
    private string _description;
    private int _necessity;


    public MiscellaneousPurchase(string item, float cost, int amount, string date, string description, int necessity) : base(item, cost, amount, date)
    {
        _description = description;
        _necessity = necessity;
    }


    public string GetDescription()
    {
        return _description;
    }

    public int GetNecessity()
    {
        return _necessity;
    }


    public override void Display()
    {
        Console.WriteLine();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Item: {GetItem()}");
        Console.WriteLine($"Cost: ${GetCost()}");
        Console.WriteLine($"Quantity: {GetAmount()}");
        Console.WriteLine($"Full Item Description: {_description}");
        if (_necessity == 1)
        {
            Console.WriteLine("This purchase was necessary.");
        }
        else
        {
            Console.WriteLine("This purchase was a splurge");
        }
    }
}