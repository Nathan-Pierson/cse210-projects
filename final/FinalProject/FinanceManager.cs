using System.Runtime.CompilerServices;

class FinanceManager
{
    private List<ProRatedPurchase> _proRated = new List<ProRatedPurchase>();
    private List<HomeGoodsPurchase> _homeGoods = new List<HomeGoodsPurchase>();
    private List<GroceriesPurchase> _groceries = new List<GroceriesPurchase>();
    private List<GasPurchase> _gas = new List<GasPurchase>();
    private List<EatingOutPurchase> _eatingOut = new List<EatingOutPurchase>();
    private List<MiscellaneousPurchase> _miscellaneous = new List<MiscellaneousPurchase>();
    private float _totalCost; //Used to find out how much a user has spent
    private float _proRatedGoal; //Goal for proRated
    private float _homeGoodsGoal; //Goal for HomeGoods
    private float _groceriesGoal; //Goal for groceries
    private float _gasGoal; //Goal for gas
    private float _eatingOutGoal; //Goal for EatingOut
    private float _miscellaneousGoal; //Goal for miscellaneous


    public FinanceManager()
    {
        _totalCost = 0;
        _proRatedGoal = 0;
        _eatingOutGoal = 0;
        _gasGoal = 0;
        _homeGoodsGoal = 0;
        _groceriesGoal = 0;
        _miscellaneousGoal = 0;
    }


    /// <summary>
    /// A method that will create a new object for each specific
    /// purchase category and add the new object to it's specific
    /// list
    /// </summary>
    public void AddPurchase()
    {
        Console.Clear();
        Console.WriteLine("Type of purchase:");
        Console.WriteLine();
        Console.WriteLine("1. ProRated Purchase");
        Console.WriteLine("2. Groceries Purchase");
        Console.WriteLine("3. Home Goods Purchase");
        Console.WriteLine("4. Gas Purchase");
        Console.WriteLine("5. Eating Out Purchase");
        Console.WriteLine("6. Miscellaneous Purchase");
        Console.Write(">>> ");

        string purchaseChoice = Console.ReadLine();
        int purchaseChoiceInt = int.Parse(purchaseChoice);

        switch (purchaseChoiceInt)
        {
            case 1: // ProRated Purchase
                {
                    //Item
                    Console.WriteLine("What is your ProRated Purchase, or monthly subscription?");
                    Console.Write(">>> ");
                    string item = Console.ReadLine();

                    //Cost
                    Console.WriteLine("What is the cost of the purchase or monthly subscription?");
                    Console.Write(">>> ");
                    string cost = Console.ReadLine();
                    float costFloat = float.Parse(cost);

                    //Date
                    Console.WriteLine("What date was this purchase made? (month/day/year)");
                    Console.Write(">>> ");
                    string date = Console.ReadLine();

                    //Times Per Year
                    Console.WriteLine("How many times per year must this get paid?");
                    Console.Write(">>> ");
                    string timesPerYear = Console.ReadLine();
                    int timesPerYearInt = int.Parse(timesPerYear);

                    //Making ProRatedPurchase Object and Calling Constructor
                    ProRatedPurchase proRated = new ProRatedPurchase(item, costFloat, 1, date, timesPerYearInt);
                    _proRated.Add(proRated);

                    break;
                }

            case 2: // Groceries Purchase
                {
                    //Item
                    Console.WriteLine("What grocery or food item did you purchase?");
                    Console.Write(">>> ");
                    string item = Console.ReadLine();

                    //Cost
                    Console.WriteLine("What is the cost of the purchase?");
                    Console.Write(">>> ");
                    string cost = Console.ReadLine();
                    float costFloat = float.Parse(cost);

                    //Amount
                    Console.WriteLine("How many did you purchase?");
                    Console.Write(">>> ");
                    string amount = Console.ReadLine();
                    int amountInt = int.Parse(amount);                    

                    //Date
                    Console.WriteLine("What date was this purchase made? (month/day/year)");
                    Console.Write(">>> ");
                    string date = Console.ReadLine();

                    //Necessity
                    Console.WriteLine("Was this purchase necessary or was it a splurge? (Yes/No)");
                    string necessity = Console.ReadLine();
                    int necessityInt = 0;
                    if (necessity == "Yes" || necessity == "yes")
                    {
                        necessityInt = 1;
                    }
                    else
                    {
                        necessityInt = 2;
                    }

                    //Making Object and Calling Constructor
                    GroceriesPurchase groceries = new GroceriesPurchase(item, costFloat, amountInt, date, necessityInt);
                    _groceries.Add(groceries);                   
                    break;
                }

            case 3: // Home Goods Purchase
                {
                    //Item
                    Console.WriteLine("What home goods item did you purchase?");
                    Console.Write(">>> ");
                    string item = Console.ReadLine();

                    //Cost
                    Console.WriteLine("What is the cost of the purchase?");
                    Console.Write(">>> ");
                    string cost = Console.ReadLine();
                    float costFloat = float.Parse(cost);

                    //One time purchase
                    Console.WriteLine("Is this a one time purchase? (Yes/No)");
                    Console.Write(">>> ");
                    string oneTime = Console.ReadLine();
                    int oneTimeInt = 0;
                    if (oneTime == "Yes" || oneTime == "yes") { oneTimeInt = 1; }
                    else{ oneTimeInt = 2; }

                    int amountInt = 0;
                    if (oneTimeInt == 1)
                    {
                        amountInt = 1;
                    }

                    else
                    {
                        //Amount
                        Console.WriteLine("How many did you purchase?");
                        Console.Write(">>> ");
                        string amount = Console.ReadLine();
                        amountInt = int.Parse(amount);
                    }                 

                    //Date
                    Console.WriteLine("What date was this purchase made? (month/day/year)");
                    Console.Write(">>> ");
                    string date = Console.ReadLine();

                    //Making Object and Calling Constructor
                    HomeGoodsPurchase homeGoods = new HomeGoodsPurchase(item, costFloat, amountInt, date, oneTimeInt);
                    _homeGoods.Add(homeGoods);             
                    break;
                }

            case 4: // Gas Purchase
                {
                    //Item
                    string item = "Gas";

                    //Cost
                    Console.WriteLine("What was the total cost of gas purchased?");
                    Console.Write(">>> ");
                    string cost = Console.ReadLine();
                    float costFloat = float.Parse(cost);

                    //Gallons
                    Console.WriteLine("How many gallons was purchased?");
                    Console.Write(">>> ");
                    string gallons = Console.ReadLine();
                    float gallonsFloat = float.Parse(gallons);

                    //Station
                    Console.WriteLine("What gas station did you buy this gas from?");
                    Console.Write(">>> ");
                    string station = Console.ReadLine();

                    //Amount
                    int amountInt = 1;                    

                    //Date
                    Console.WriteLine("What date was this purchase made? (month/day/year)");
                    Console.Write(">>> ");
                    string date = Console.ReadLine();

                    //Making Object and Calling Constructor
                    GasPurchase gas = new GasPurchase(item, costFloat, amountInt, date, gallonsFloat, station);
                    _gas.Add(gas);
                    break;
                }

            case 5: // Eating Out Purchase
                {
                    break;
                }

            case 6: // Miscellaneous Purchase
                {
                    break;
                }
        }

    }

    /// <summary>
    /// A method to display all of the finances from all of the
    /// purchases that have been inputted.
    /// </summary>
    public void DisplayFinances()
    {

    }


    /// <summary>
    /// A method that will calculate the total amount of money that
    /// was spent from a specific time period.
    /// </summary>
    public void TotalSpent()
    {

    }


    /// <summary>
    /// This is a method that will set a financial goal for each of
    /// the different spending categories.
    /// </summary>
    public void SetFinancialGoal()
    {

    }


    /// <summary>
    /// This is a method that will save all of the finances and information
    /// onto a file that can be reloaded for further use at any given time.
    /// </summary>
    public void SaveFinances()
    {

    }


    /// <summary>
    /// This is a method that will Load the finances from a specific file
    /// so that it can be added to.
    /// </summary>
    public void LoadFinances()
    {

    }
}