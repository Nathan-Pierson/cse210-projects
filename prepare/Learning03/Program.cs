using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fractions Program");
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());

        Fraction f2 = new Fraction(3);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}