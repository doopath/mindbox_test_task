namespace Task1.Geometry.Tests.Shapes;

using Task1.Geometry.Shapes;

public class CircleTests
{
    [TestCase(-1)]
    [TestCase(double.NaN)]
    [TestCase(double.PositiveInfinity)]
    [TestCase(double.NegativeInfinity)]
    public void Circle_InvalidRadius_ThrowsArgumentException(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Test]
    public void Circle_ValidRadius_DoesNotThrowArgumentException()
    {
        Assert.DoesNotThrow(() => new Circle(1));
    }

    [TestCase(0, 0)]
    [TestCase(1, Math.PI)]
    [TestCase(2, 4 * Math.PI)]
    [TestCase(0.5, Math.PI / 4)]
    public void Circle_GetArea_ReturnsCorrectArea(double radius, double expectedArea)
    {
        var circle = new Circle(radius);
        Assert.That(circle.GetArea(), Is.EqualTo(expectedArea).Within(1e-10));
    }
}