using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int stop = 1;
        while (stop != 0){
            Console.Write("Please enter a number: ");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            if (n == 0){
                int sum = 0;
                foreach (int number in numbers){
                    sum += number;
                }
                Console.WriteLine($"The Sum of your numbers is: {sum}");
                double average = (double)sum / (double)numbers.Count();
                Console.WriteLine($"The Average is: {average:F2}");
                int max = numbers.Max();
                Console.WriteLine($"The maximum number is: {max}");
                stop = 0;

                }
            else{
            numbers.Add(n);
            }
        }
    }
}