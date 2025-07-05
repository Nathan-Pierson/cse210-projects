abstract class Purchase
{
    private string _item;
    private float _cost;
    private int _amount;
    private string _date;


    public Purchase(string item, float cost, int amount, string date)
    {
        _item = item;
        _cost = cost;
        _amount = amount;
        _date = date;
    }


    /// <summary>
    /// An abstract method used to calculate the total cost of
    /// all the purchases that have been entered based on the
    /// amount they bought.
    /// </summary>
    public abstract void TotalCost();


    /// <summary>
    /// An abstract method used to display everything that the user
    /// entered that is relevant to the purchase.
    /// </summary>
    public abstract void Display();
}