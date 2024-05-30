namespace Task1.Geometry;

using Task1.Geometry.Shapes;

public class Area
{
    public static double GetArea(IShape shape) => shape.GetArea();
}