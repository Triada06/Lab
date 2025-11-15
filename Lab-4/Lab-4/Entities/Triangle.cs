namespace Lab_4.Entities;

public class Triangle : IShape
{
    public double Height { get; set; }
    public double Length { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle()
    {
    }

    public Triangle(double height, double length, double b, double c)
    {
        Height = height;
        Length = length;
        B = b;
        C = c;
    }

    public double GetArea()
        => (Height * Length) / 2;

    public double GetPerimeter()
        => Length + B + C;
}