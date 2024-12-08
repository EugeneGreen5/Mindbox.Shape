using Mindbox.Shape.Core.Models;

namespace Mindbox.Shape.UnitTests;

public class TriangleTests
{
    [Fact]
    public void TriangleArea_IsCorrect()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.CalculateArea(), 10);
    }

    [Fact]
    public void Triangle_IsValid_TrueForValidSides()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsValid());
    }

    [Fact]
    public void Triangle_IsValid_FalseForInvalidSides()
    {
        var triangle = new Triangle(1, 2, 10);
        Assert.False(triangle.IsValid());
    }

    [Fact]
    public void Triangle_IsRightTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void Triangle_IsNotRightTriangle()
    {
        var triangle = new Triangle(3, 4, 6);
        Assert.False(triangle.IsRightTriangle());
    }
}