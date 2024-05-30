namespace Task1.Geometry.Shapes;

public class Circle : ICircle
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}