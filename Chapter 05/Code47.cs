abstract class Shape
{
    public abstract double CalculateArea();
    public void DisplayInfo()
    {
        Console.WriteLine("This is a shape.");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Square : Shape
{
    public double SideLength { get; set; }

    public override double CalculateArea()
    {
        return SideLength * SideLength;
    }
}