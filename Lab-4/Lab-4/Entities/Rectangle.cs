namespace Lab_4.Entities;

public class Rectangle : IShape
{
    public double A { get; set; }
    public double B { get; set; }

    public Rectangle()
    {
    }

    public Rectangle(double a, double b)
    {
        A = a;
        B = b;
    }

    public double GetArea()
        => A * B;

    public double GetPerimeter()
        => (A + B) * 2;
}