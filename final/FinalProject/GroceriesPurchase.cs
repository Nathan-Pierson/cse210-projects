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

    public override void TotalCost()
    {
        throw new NotImplementedException();
    }


    public override void Display()
    {
        throw new NotImplementedException();
    }
}