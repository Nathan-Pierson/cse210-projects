class HomeGoodsPurchase : Purchase
{
    private int _oneTimePurchase;

    public HomeGoodsPurchase(string item, float cost, int amount, string date, int times) : base(item, cost, amount, date)
    {
        _oneTimePurchase = times;
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