class GasPurchase : Purchase
{
    private float _gallons;
    private string _station;


    public GasPurchase(string item, float cost, int amount, string date, float gallons, string station) : base(item, cost, amount, date)
    {
        _gallons = gallons;
        _station = station;
    }


    public override void TotalCost()
    {
        throw new NotImplementedException();
    }


    public override void Display()
    {
        throw new NotImplementedException();
    }
}