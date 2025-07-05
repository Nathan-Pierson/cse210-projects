class ProRatedPurchase : Purchase
{
    private int _timesPerYear;

    public ProRatedPurchase(string item, float cost, int amount, string date, int times) : base(item, cost, amount, date)
    {
        _timesPerYear = times;
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