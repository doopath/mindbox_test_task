using Task1.Geometry.Shapes;

namespace Task1.Geometry;

public class Area
{
    public static double GetArea(IShape shape) => shape.GetArea();
}