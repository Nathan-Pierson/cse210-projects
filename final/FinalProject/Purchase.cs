abstract class Purchase
{
    private string _item;
    private float _cost;
    private int _amount;
    private string _date;

    //Constructor for object Purchase
    public Purchase(string item, float cost, int amount, string date)
    {
        _item = item;
        _cost = cost;
        _amount = amount;
        _date = date;
    }

    public string GetItem()
    {
        return _item;
    }

    public float GetCost()
    {
        return _cost;
    }

    public int GetAmount()
    {
        return _amount;
    }

    public string GetDate()
    {
        return _date;
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