using System.Runtime.CompilerServices;

class FinanceManager
{
    //Attributes of lists of objects for each purchase category
    private List<ProRatedPurchase> _proRated = new List<ProRatedPurchase>();
    private List<HomeGoodsPurchase> _homeGoods = new List<HomeGoodsPurchase>();
    private List<GroceriesPurchase> _groceries = new List<GroceriesPurchase>();
    private List<GasPurchase> _gas = new List<GasPurchase>();
    private List<EatingOutPurchase> _eatingOut = new List<EatingOutPurchase>();
    private List<MiscellaneousPurchase> _miscellaneous = new List<MiscellaneousPurchase>();

    //Attributes for all of the total costs
    private float _totalCost; //Used to find out how much a user has spent
    private float _proRatedTotal; //Total spent for ProRated
    private float _groceriesTotal; //Total spent for Groceries
    private float _homeGoodsTotal; //Total spent for Home Goods
    private float _gasTotal; //Total spent for Gas
    private float _eatingOutTotal; //Total spent for Eating Out
    private float _miscellaneousTotal; //Total spent for Miscellaneous

    //Attributes for financial goals
    private float _totalGoal; //Goal for total spent
    private float _proRatedGoal; //Goal for proRated
    private float _homeGoodsGoal; //Goal for HomeGoods
    private float _groceriesGoal; //Goal for groceries
    private float _gasGoal; //Goal for gas
    private float _eatingOutGoal; //Goal for EatingOut
    private float _miscellaneousGoal; //Goal for miscellaneous

    /// <summary>
    /// Constructor to initialize the FinanceManager Object
    /// </summary>
    public FinanceManager()
    {
        //initializing total attributes
        _totalCost = 0;
        _proRatedTotal = 0;
        _groceriesTotal = 0;
        _homeGoodsTotal = 0;
        _eatingOutTotal = 0;
        _gasTotal = 0;
        _miscellaneousTotal = 0;

        //initializing goal attributes
        _totalGoal = 0;
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
        Console.WriteLine();
        Console.Write(">>> ");

        string purchaseChoice = Console.ReadLine();
        int purchaseChoiceInt = int.Parse(purchaseChoice);

        switch (purchaseChoiceInt)
        {
            case 1: // ProRated Purchase
                {
                    Console.Clear();

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
                    Console.Clear();

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
                    Console.WriteLine("Was this purchase necessary? (Yes/No)");
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
                    Console.Clear();

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
                    Console.WriteLine("Is this an item that you will buy again in the future? (Yes/No)");
                    Console.Write(">>> ");
                    string oneTime = Console.ReadLine();
                    int oneTimeInt = 0;
                    if (oneTime == "Yes" || oneTime == "yes") { oneTimeInt = 1; }
                    else { oneTimeInt = 2; }

                    int amountInt = 0;
                    if (oneTimeInt == 2)
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
                    HomeGoodsPurchase homeGoods = new HomeGoodsPurchase(item, costFloat, amountInt, date, oneTime);
                    _homeGoods.Add(homeGoods);
                    break;
                }

            case 4: // Gas Purchase
                {
                    Console.Clear();

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
                    Console.Clear();

                    //Item
                    Console.WriteLine("What order/food did you purchase?");
                    Console.Write(">>> ");
                    string item = Console.ReadLine();

                    //Establishment
                    Console.WriteLine("What establishment was this purchase made at?");
                    Console.Write(">>> ");
                    string establishment = Console.ReadLine();

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

                    //Was Date???
                    Console.WriteLine("Was this purchase for a date? (Yes/No)");
                    Console.Write(">>> ");
                    string answer = Console.ReadLine();
                    int isDate = 0;
                    if (answer == "Yes" || answer == "yes")
                    {
                        isDate = 1;
                    }
                    else
                    {
                        isDate = 2;
                    }

                    //Making Object and Calling Constructor
                    EatingOutPurchase eatingOut = new EatingOutPurchase(item, costFloat, amountInt, date, establishment, isDate);
                    _eatingOut.Add(eatingOut);
                    break;
                }

            case 6: // Miscellaneous Purchase
                {
                    Console.Clear();

                    //Item
                    Console.WriteLine("What item did you purchase?");
                    Console.Write(">>> ");
                    string item = Console.ReadLine();

                    //Description
                    Console.WriteLine("What is a quick description of why you purchased this item.");
                    Console.Write(">>> ");
                    string description = Console.ReadLine();

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
                    Console.WriteLine("Was this purchase necessary? (Yes/No)");
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
                    MiscellaneousPurchase miscellaneous = new MiscellaneousPurchase(item, costFloat, amountInt, date, description, necessityInt);
                    _miscellaneous.Add(miscellaneous);
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
        TotalSpent();
        Console.Clear();
        Console.WriteLine("Do you want:");
        Console.WriteLine("1. All Transaction History");
        Console.WriteLine("2. Quick Budget Remainder View");
        Console.Write(">>> ");
        string dis = Console.ReadLine();
        int disInt = int.Parse(dis);

        Console.Clear();
        if (disInt == 1) //All transaction History
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //ProRated Transactions
            if (_proRated.Count != 0)
            {
                Console.WriteLine();
                Console.WriteLine("ProRated Purchases");
                Console.WriteLine($"Budget: {_proRatedGoal}");
                Console.WriteLine($"Total Spent: ${_proRatedTotal}");
                Console.WriteLine($"Amount Remaining: {_proRatedGoal - _proRatedTotal}");
            }
            foreach (ProRatedPurchase pro in _proRated)
            {
                pro.Display();
            }

            //Groceries Transactions
            if (_groceries.Count != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Groceries Purchases");
                Console.WriteLine($"Budget: {_groceriesGoal}");
                Console.WriteLine($"Total Spent: ${_groceriesTotal}");
                Console.WriteLine($"Amount Remaining: {_groceriesGoal - _groceriesTotal}");
            }
            foreach (GroceriesPurchase gro in _groceries)
            {
                gro.Display();
            }

            //Home Goods Transactions
            if (_homeGoods.Count != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Home Goods Purchases");
                Console.WriteLine($"Budget: {_homeGoodsGoal}");
                Console.WriteLine($"Total Spent: ${_homeGoodsTotal}");
                Console.WriteLine($"Amount Remaining: {_homeGoodsGoal - _homeGoodsTotal}");
            }
            foreach (HomeGoodsPurchase home in _homeGoods)
            {
                home.Display();
            }

            //Gas Transactions
            if (_gas.Count != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Gas Purchases");
                Console.WriteLine($"Budget: {_gasGoal}");
                Console.WriteLine($"Total Spent: ${_gasTotal}");
                Console.WriteLine($"Amount Remaining: {_gasGoal - _gasTotal}");
            }
            foreach (GasPurchase gas in _gas)
            {
                gas.Display();
            }

            //Eating Out Transaction
            if (_eatingOut.Count != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Eating Out Purchases");
                Console.WriteLine($"Budget: {_eatingOutGoal}");
                Console.WriteLine($"Total Spent: ${_eatingOutTotal}");
                Console.WriteLine($"Amount Remaining: {_eatingOutGoal - _eatingOutTotal}");
            }
            foreach (EatingOutPurchase eat in _eatingOut)
            {
                eat.Display();
            }

            //Miscellaneous Transactions
            if (_miscellaneous.Count != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Miscellaneous Purchases");
                Console.WriteLine($"Budget: {_miscellaneousGoal}");
                Console.WriteLine($"Total Spent: ${_miscellaneousTotal}");
                Console.WriteLine($"Amount Remaining: {_miscellaneousGoal - _miscellaneousTotal}");
            }
            foreach (MiscellaneousPurchase mis in _miscellaneous)
            {
                mis.Display();
            }

            Console.WriteLine();
            Console.Write("Press Enter to Continue...");
            Console.ReadLine();
        }

        else //Displays the budget remaining
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("ProRated Purchases");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Budget: {_proRatedGoal}");
            Console.WriteLine($"Total Spent: ${_proRatedTotal}");
            Console.WriteLine($"Amount Remaining: {_proRatedGoal - _proRatedTotal}");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Groceries Purchases");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Budget: {_groceriesGoal}");
            Console.WriteLine($"Total Spent: ${_groceriesTotal}");
            Console.WriteLine($"Amount Remaining: {_groceriesGoal - _groceriesTotal}");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Home Goods Purchases");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Budget: {_homeGoodsGoal}");
            Console.WriteLine($"Total Spent: ${_homeGoodsTotal}");
            Console.WriteLine($"Amount Remaining: {_homeGoodsGoal - _homeGoodsTotal}");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Gas Purchases");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Budget: {_gasGoal}");
            Console.WriteLine($"Total Spent: ${_gasTotal}");
            Console.WriteLine($"Amount Remaining: {_gasGoal - _gasTotal}");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Eating Out Purchases");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Budget: {_eatingOutGoal}");
            Console.WriteLine($"Total Spent: ${_eatingOutTotal}");
            Console.WriteLine($"Amount Remaining: {_eatingOutGoal - _eatingOutTotal}");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Miscellaneous Purchases");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Budget: {_miscellaneousGoal}");
            Console.WriteLine($"Total Spent: ${_miscellaneousTotal}");
            Console.WriteLine($"Amount Remaining: {_miscellaneousGoal - _miscellaneousTotal}");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine();
            Console.Write("Press Enter to Continue...");
            Console.ReadLine();
        }
    }


    /// <summary>
    /// A method that will calculate the total amount of money that
    /// was spent from a specific time period.
    /// </summary>
    public void TotalSpent()
    {
        _proRatedTotal = 0;
        _groceriesTotal = 0;
        _homeGoodsTotal = 0;
        _eatingOutTotal = 0;
        _gasTotal = 0;
        _miscellaneousTotal = 0;

        foreach (ProRatedPurchase pro in _proRated)
        {
            float money = pro.GetCost() * pro.GetAmount();
            _totalCost += money;
            _proRatedTotal += money;
        }

        foreach (GroceriesPurchase gro in _groceries)
        {
            float money = gro.GetCost() * gro.GetAmount();
            _totalCost += money;
            _groceriesTotal += money;
        }

        foreach (HomeGoodsPurchase home in _homeGoods)
        {
            float money = home.GetCost() * home.GetAmount();
            _totalCost += money;
            _homeGoodsTotal += money;
        }

        foreach (GasPurchase gas in _gas)
        {
            float money = gas.GetCost() * gas.GetAmount();
            _totalCost += money;
            _gasTotal += money;
        }

        foreach (EatingOutPurchase eat in _eatingOut)
        {
            float money = eat.GetCost() * eat.GetAmount();
            _totalCost += money;
            _eatingOutTotal += money;
        }

        foreach (MiscellaneousPurchase mis in _miscellaneous)
        {
            float money = mis.GetCost() * mis.GetAmount();
            _totalCost += money;
            _miscellaneousTotal += money;
        }
    }


    /// <summary>
    /// This is a method that will set a financial goal for each of
    /// the different spending categories.
    /// </summary>
    public void SetFinancialGoal()
    {
        Console.Clear();
        Console.WriteLine("What budget would you like to set?");
        Console.WriteLine();
        Console.WriteLine("1. Total Budget");
        Console.WriteLine("2. ProRated Budget");
        Console.WriteLine("3. Groceries Budget");
        Console.WriteLine("4. Home Goods Budget");
        Console.WriteLine("5. Gas Budget");
        Console.WriteLine("6. Eating Out Budget");
        Console.WriteLine("7. Miscellaneous Budget");
        Console.Write(">>> ");
        string option = Console.ReadLine();
        int optionInt = int.Parse(option);

        string budget = "0";
        float budgetFloat = 0;
        switch (optionInt)
        {
            case 1: //Total Budget
                {
                    Console.WriteLine("What do you want the total budget to be?");
                    Console.Write(">>> ");
                    budget = Console.ReadLine();
                    budgetFloat = float.Parse(budget);
                    _totalGoal = budgetFloat;
                    break;
                }

            case 2: //Pro Rated Budget
                {
                    Console.WriteLine("What do you want the total budget to be?");
                    Console.Write(">>> ");
                    budget = Console.ReadLine();
                    budgetFloat = float.Parse(budget);
                    _proRatedGoal = budgetFloat;                    
                    break;
                }

            case 3: //Grocery Budget
                {
                    Console.WriteLine("What do you want the total budget to be?");
                    Console.Write(">>> ");
                    budget = Console.ReadLine();
                    budgetFloat = float.Parse(budget);
                    _groceriesGoal = budgetFloat;                    
                    break;
                }

            case 4: //Home Good Budget
                {
                    Console.WriteLine("What do you want the total budget to be?");
                    Console.Write(">>> ");
                    budget = Console.ReadLine();
                    budgetFloat = float.Parse(budget);
                    _homeGoodsGoal = budgetFloat;                    
                    break;
                }

            case 5: //Gas Budget
                {
                    Console.WriteLine("What do you want the total budget to be?");
                    Console.Write(">>> ");
                    budget = Console.ReadLine();
                    budgetFloat = float.Parse(budget);
                    _gasGoal = budgetFloat;                    
                    break;
                }

            case 6: //Eating Out Budget
                {
                    Console.WriteLine("What do you want the total budget to be?");
                    Console.Write(">>> ");
                    budget = Console.ReadLine();
                    budgetFloat = float.Parse(budget);
                    _eatingOutGoal = budgetFloat;                    
                    break;
                }

            case 7: //Miscellaneous Budget
                {
                    Console.WriteLine("What do you want the total budget to be?");
                    Console.Write(">>> ");
                    budget = Console.ReadLine();
                    budgetFloat = float.Parse(budget);
                    _miscellaneousGoal = budgetFloat;                    
                    break;
                }                                                                                                
        }
    }


    /// <summary>
    /// This is a method that will save all of the finances and information
    /// onto a file that can be reloaded for further use at any given time.
    /// </summary>
    public void SaveFinances()
    {
        Console.WriteLine("What do you want to name the file?");
        Console.Write(">>> ");
        string fileName = Console.ReadLine();

    if (!fileName.EndsWith(".txt"))
    {
        fileName += ".txt";
    }

    try
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            // Save goals first
            writer.WriteLine("GOALS");
            writer.WriteLine($"{_totalGoal}|{_proRatedGoal}|{_homeGoodsGoal}|{_groceriesGoal}|{_gasGoal}|{_eatingOutGoal}|{_miscellaneousGoal}");
            
            // Save ProRated purchases
            writer.WriteLine("PRORATED");
            foreach (ProRatedPurchase purchase in _proRated)
            {
                writer.WriteLine($"{purchase.GetItem()}|{purchase.GetCost()}|{purchase.GetAmount()}|{purchase.GetDate()}|{purchase.GetTimesPerYear()}");
            }
            
            // Save Groceries purchases
            writer.WriteLine("GROCERIES");
            foreach (GroceriesPurchase purchase in _groceries)
            {
                writer.WriteLine($"{purchase.GetItem()}|{purchase.GetCost()}|{purchase.GetAmount()}|{purchase.GetDate()}|{purchase.GetNecessity()}");
            }
            
            // Save Home Goods purchases
            writer.WriteLine("HOMEGOODS");
            foreach (HomeGoodsPurchase purchase in _homeGoods)
            {
                writer.WriteLine($"{purchase.GetItem()}|{purchase.GetCost()}|{purchase.GetAmount()}|{purchase.GetDate()}|{purchase.GetOneTimePurchase()}");
            }
            
            // Save Gas purchases
            writer.WriteLine("GAS");
            foreach (GasPurchase purchase in _gas)
            {
                writer.WriteLine($"{purchase.GetItem()}|{purchase.GetCost()}|{purchase.GetAmount()}|{purchase.GetDate()}|{purchase.GetGallons()}|{purchase.GetStation()}");
            }
            
            // Save Eating Out purchases
            writer.WriteLine("EATINGOUT");
            foreach (EatingOutPurchase purchase in _eatingOut)
            {
                writer.WriteLine($"{purchase.GetItem()}|{purchase.GetCost()}|{purchase.GetAmount()}|{purchase.GetDate()}|{purchase.GetEstablishment()}|{purchase.GetIsDate()}");
            }
            
            // Save Miscellaneous purchases
            writer.WriteLine("MISCELLANEOUS");
            foreach (MiscellaneousPurchase purchase in _miscellaneous)
            {
                writer.WriteLine($"{purchase.GetItem()}|{purchase.GetCost()}|{purchase.GetAmount()}|{purchase.GetDate()}|{purchase.GetDescription()}|{purchase.GetNecessity()}");
            }
            
            writer.WriteLine("END");
        }
        
        Console.WriteLine($"Finances saved successfully to {fileName}!");
        Console.Write("Press Enter to Continue...");
        Console.ReadLine();
    }
    
    catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
            Console.Write("Press Enter to Continue...");
            Console.ReadLine();
        }
    }


    /// <summary>
    /// This is a method that will Load the finances from a specific file
    /// so that it can be added to.
    /// </summary>
    public void LoadFinances()
    {
    Console.WriteLine("What is the name of the file you want to load?");
    Console.Write(">>> ");
    string fileName = Console.ReadLine();
    
    if (!fileName.EndsWith(".txt"))
        fileName += ".txt";

    if (!File.Exists(fileName))
    {
        Console.WriteLine($"File {fileName} does not exist!");
        Console.Write("Press Enter to Continue...");
        Console.ReadLine();
        return;
    }

    try
    {
        // Clear existing data
        _proRated.Clear();
        _groceries.Clear();
        _homeGoods.Clear();
        _gas.Clear();
        _eatingOut.Clear();
        _miscellaneous.Clear();

        string[] lines = File.ReadAllLines(fileName);
        string currentSection = "";
        
        foreach (string line in lines)
        {
            if (line == "GOALS" || line == "PRORATED" || line == "GROCERIES" || 
                line == "HOMEGOODS" || line == "GAS" || line == "EATINGOUT" || 
                line == "MISCELLANEOUS" || line == "END")
            {
                currentSection = line;
                continue;
            }
            
            if (string.IsNullOrEmpty(line)) continue;
            
            string[] parts = line.Split('|');
            
            if (currentSection == "GOALS" && parts.Length >= 7)
            {
                _totalGoal = float.Parse(parts[0]);
                _proRatedGoal = float.Parse(parts[1]);
                _homeGoodsGoal = float.Parse(parts[2]);
                _groceriesGoal = float.Parse(parts[3]);
                _gasGoal = float.Parse(parts[4]);
                _eatingOutGoal = float.Parse(parts[5]);
                _miscellaneousGoal = float.Parse(parts[6]);
            }
            else if (currentSection == "PRORATED" && parts.Length >= 5)
            {
                _proRated.Add(new ProRatedPurchase(parts[0], float.Parse(parts[1]), 
                    int.Parse(parts[2]), parts[3], int.Parse(parts[4])));
            }
            else if (currentSection == "GROCERIES" && parts.Length >= 5)
            {
                _groceries.Add(new GroceriesPurchase(parts[0], float.Parse(parts[1]), 
                    int.Parse(parts[2]), parts[3], int.Parse(parts[4])));
            }
            else if (currentSection == "HOMEGOODS" && parts.Length >= 5)
            {
                _homeGoods.Add(new HomeGoodsPurchase(parts[0], float.Parse(parts[1]), 
                    int.Parse(parts[2]), parts[3], parts[4]));
            }
            else if (currentSection == "GAS" && parts.Length >= 6)
            {
                _gas.Add(new GasPurchase(parts[0], float.Parse(parts[1]), 
                    int.Parse(parts[2]), parts[3], float.Parse(parts[4]), parts[5]));
            }
            else if (currentSection == "EATINGOUT" && parts.Length >= 6)
            {
                _eatingOut.Add(new EatingOutPurchase(parts[0], float.Parse(parts[1]), 
                    int.Parse(parts[2]), parts[3], parts[4], int.Parse(parts[5])));
            }
            else if (currentSection == "MISCELLANEOUS" && parts.Length >= 6)
            {
                _miscellaneous.Add(new MiscellaneousPurchase(parts[0], float.Parse(parts[1]), 
                    int.Parse(parts[2]), parts[3], parts[4], int.Parse(parts[5])));
            }
        }
        
        TotalSpent();
        Console.WriteLine($"Finances loaded successfully from {fileName}!");
        Console.Write("Press Enter to Continue...");
        Console.ReadLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading file: {ex.Message}");
        Console.Write("Press Enter to Continue...");
        Console.ReadLine();
    }
    }
}