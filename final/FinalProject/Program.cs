using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Finance Manager");
        Console.WriteLine();
        int q = 1;
        FinanceManager finance = new FinanceManager();

        while (q != 0)
        {
            Menu();
            string choice = Console.ReadLine();
            int choiceInt = int.Parse(choice);

            switch (choiceInt)
            {
                case 1: //Add Purchase
                    {
                        finance.AddPurchase();
                        break;
                    }

                case 2: // Set Financial Goal
                    {
                        finance.SetFinancialGoal();
                        break;
                    }

                case 3: // View Finances
                    {
                        finance.DisplayFinances();
                        break;
                    }

                case 4: // Save Finance History
                    {
                        
                        break;
                    }

                case 5: // Load Finances
                    {
                        break;
                    }

                case 0: // Quit
                    {
                        break;
                    }
            }
        }
    }

    public static void Menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine();
        Console.WriteLine("1. Add Purchase");
        Console.WriteLine("2. Set Financial Goal");
        Console.WriteLine("3. View Finances");
        Console.WriteLine("4. Save Finance History");
        Console.WriteLine("5. Load Finances");
        Console.WriteLine("0. Quit");
        Console.WriteLine("What would you like to do?");
        Console.Write("> ");
    }
}