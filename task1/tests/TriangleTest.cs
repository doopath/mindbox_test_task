using Task1.Geometry.Shapes;

namespace Task1.Geometry.Tests.Shapes;

public class TriangleTests
{
    [Test]
    public void TestTriangle_InvalidTriangle()
    {
        double sideA = 1;
        double sideB = 1;
        double sideC = 3;

        try
        {
            Triangle triangle = new(sideA, sideB, sideC);
        } catch (ArgumentException)
        {
            Assert.Pass("Passed");
        }
    }

    [Test]
    public void TestTriangle_ValidArea_RightTriangle()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        Triangle triangle = new(sideA, sideB, sideC);

        Assert.Multiple(() =>
        {
            Assert.That(triangle.IsRight);
            Assert.That(triangle.GetArea(), Is.EqualTo(6));
        });
    }
}