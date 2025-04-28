using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Console.Write("Guess the Magic Number: ");
        string guess = Console.ReadLine();
        int g = int.Parse(guess);

        while (g != number){
            if (g < number){
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("Lower");
            }
            Console.Write("Please guess again: ");
            guess = Console.ReadLine();
            g = int.Parse(guess);
        } 

        Console.WriteLine("You guessed the Correct number!");
        
    }
}