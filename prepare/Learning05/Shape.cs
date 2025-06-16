public abstract class Shape
{
    private string _color { get; set; }


    public Shape(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}