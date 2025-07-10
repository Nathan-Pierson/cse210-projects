class GasPurchase : Purchase
{
    private float _gallons;
    private string _station;


    public GasPurchase(string item, float cost, int amount, string date, float gallons, string station) : base(item, cost, amount, date)
    {
        _gallons = gallons;
        _station = station;
    }

    public float GetGallons()
    {
        return _gallons;
    }

    public string GetStation()
    {
        return _station;
    }


    public override void Display()
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Item: {GetItem()}");
        Console.WriteLine($"Cost: ${GetCost()}");
        Console.WriteLine($"Gallons: {_gallons}");
        Console.WriteLine($"Gas Station: {_station}");
    }
}