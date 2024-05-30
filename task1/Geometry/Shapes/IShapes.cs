namespace Task1.Geometry.Shapes;

public interface IShape
{
    double GetArea();
}

public interface ICircle : IShape
{
    double Radius { get; }
}

public interface ITriangle : IShape
{
    double SideA { get; }
    double SideB { get; }
    double SideC { get; }
    bool IsRight { get; }
}