class EatingOutPurchase : Purchase
{
    private string _establishment;
    private int _isDate;


    public EatingOutPurchase(string item, float cost, int amount, string date, string establishment, int isDate) : base(item, cost, amount, date)
    {
        _establishment = establishment;
        _isDate = isDate;
    }

    public string GetEstablishment()
    {
        return _establishment;
    }

    public int GetIsDate()
    {
        return _isDate;
    }


    public override void Display()
    {
        Console.WriteLine();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Item: {GetItem()}");
        Console.WriteLine($"Cost: ${GetCost()}");
        Console.WriteLine($"Quantity: {GetAmount()}");
        Console.WriteLine($"Establishment: {_establishment}");
        if (_isDate == 1)
        {
            Console.WriteLine("This Was a Date!!!");
        }
        else
        {
            Console.WriteLine("This was not a date");
        }
    }
}