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

    public override void TotalCost()
    {
        throw new NotImplementedException();
    }


    public override void Display()
    {
        throw new NotImplementedException();
    }
}