namespace Task1.Geometry.Shapes;

public class Triangle : ITriangle
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        RequireExistence();
    }

    public bool IsRight { get {
        return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2);
    }}

    public double GetArea()
    {
        double p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    protected virtual void RequireExistence()
    {
        if (SideA <= 0 || SideB <= 0 || SideC <= 0)
        {
            throw new ArgumentException("Triangle sides must be greater than 0!");
        }

        if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
        {
            throw new ArgumentException("Triangle sides must satisfy the triangle inequality!");
        }
    }
}