class HomeGoodsPurchase : Purchase
{
    private string _oneTimePurchase;

    public HomeGoodsPurchase(string item, float cost, int amount, string date, string times) : base(item, cost, amount, date)
    {
        _oneTimePurchase = times;
    }

    public string GetOneTimePurchase()
    {
        return _oneTimePurchase;
    }


    public override void Display()
    {
        Console.WriteLine();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Item: {GetItem()}");
        Console.WriteLine($"Cost: ${GetCost()}");
        Console.WriteLine($"Quantity: {GetAmount()}");
        Console.WriteLine($"Will you purchase this again?: {_oneTimePurchase}");
    }
}