class EatingOutPurchase : Purchase
{
    private string _establishment;
    private int _isDate;


    public EatingOutPurchase(string item, float cost, int amount, string date, string establishment, int isDate) : base(item, cost, amount, date)
    {
        _establishment = establishment;
        _isDate = isDate;
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