
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Test;

public class FigureAreaCalculatorTests
{
    [Fact]
    public void CirclePositiveNumberRadiusAreaTest()
    {
        Assert.Equal(78.53981633974483, new Circle(5).Area);
    }

    [Fact]
    public void CreateCircleNegativeNumberRadiusTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
    }

    [Fact]
    public void TriangleNegativeNumberHeightsTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 1, 4));
    }

    [Fact]
    public void TrianglePositiveNumberHeightsAreaTest()
    {
        Assert.Equal(1.479019945774904, new Triangle(1, 3, 3).Area);
    }

    [Fact]
    public void TriangleRightangledPositiveTest()
    {
        Assert.True(new Triangle(9,12, 15).Rightangled);
    }
}