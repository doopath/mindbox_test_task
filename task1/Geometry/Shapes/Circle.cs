namespace Task1.Geometry.Shapes;

public class Circle : ICircle
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
        RequireExistence();
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    protected virtual void RequireExistence()
    {
        if (Radius < 0 || double.IsNaN(Radius) || double.IsInfinity(Radius))
        {
            throw new ArgumentException("Radius must be greater than 0!");
        }
    }
}