using System;

class Program
{
    static void Main(string[] args)
    {
        //This is a a quick test on getting user input
        
        //get radius of the circle
        Console.Write("Please enter the radius: ");
        string r = Console.ReadLine();
        double radius = double.Parse(r);
        //compute the area of the circle
        double area = Math.PI * radius * radius;

        //display the area
        Console.Write(area);

        //random stuff
        int x = 3;
        string s = "Goodbye";
        float f = 3.14F;
        double d = 5.21;
        Console.WriteLine($"Hello, {s}, {x}, {d}, {f}, Sandbox World!");
    }
}