using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square(4, "green");
        double area = s.GetArea();
        Console.WriteLine($"The area of the square is {area}");


        Rectangle r = new Rectangle(10, 5, "blue");
        area = r.GetArea();
        Console.WriteLine($"The area of the rectangle is {area}");

        Circle c = new Circle(5, "orange");
        area = c.GetArea();
        Console.WriteLine($"The area of the circle is {area}");

    }
}