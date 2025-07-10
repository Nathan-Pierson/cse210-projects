class GroceriesPurchase : Purchase
{
    private int _necessity;


    public GroceriesPurchase(string item, float cost, int amount, string date, int necessity) : base(item, cost, amount, date)
    {
        _necessity = necessity;
    }

    public int GetNecessity()
    {
        return _necessity;
    }


    public override void Display()
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Item: {GetItem()}");
        Console.WriteLine($"Cost: ${GetCost()}");
        Console.WriteLine($"Quantity: {GetAmount()}");
        if (_necessity == 1)
        {
            Console.WriteLine("This item was necessary!");
        }
        else
        {
            Console.WriteLine("This item was not necessary.");
        }
    }
}