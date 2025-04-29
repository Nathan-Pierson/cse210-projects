using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();
        string name = UserName();
        int number = UserNumber();
        int n = square(number);
        Console.WriteLine($"{name}, the square root of your number is {n}");
    }

    static void Welcome(){
        Console.WriteLine("Welcome to the Program");
    }

    static string UserName(){
        Console.Write("Enter Your Name: ");
        string Name = Console.ReadLine();

        return Name;
    }

    static int UserNumber(){
        Console.Write("Enter a number: ");
        string s = Console.ReadLine();
        int number = int.Parse(s);

        return number;
    }

    static int square(int number){
        int numberSquared = number * number;

        return numberSquared; 
    }

}