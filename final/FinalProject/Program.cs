using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
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
    }
}