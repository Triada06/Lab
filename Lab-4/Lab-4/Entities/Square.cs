namespace Lab_4.Entities;

public class Square : IShape
{
    public int A { get; set; }

    public Square()
    {
    }

    public Square(int a)
    {
        A = a;
    }

    public double GetArea()
        => A * A;

    public double GetPerimeter()
        => 4 * A;
}