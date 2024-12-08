using Mindbox.Shape.Core;
using Mindbox.Shape.Core.Interfaces;
using Mindbox.Shape.Core.Models;

namespace Mindbox.Shape.UnitTests;

public class ShapeAreaCalculatorTests
{
    [Fact]
    public void ShapeAreaCalculator_WorksForCircle()
    {
        IShape shape = new Circle(5);
        Assert.Equal(Math.PI * 25, ShapeAreaCalculator.CalculateArea(shape), 10);
    }

    [Fact]
    public void ShapeAreaCalculator_ThrowsForInvalidCircle()
    {
        IShape shape = new Circle(0);
        Assert.Throws<InvalidOperationException>(() => ShapeAreaCalculator.CalculateArea(shape));
    }

    [Fact]
    public void ShapeAreaCalculator_WorksForTriangle()
    {
        IShape shape = new Triangle(3, 4, 5);
        Assert.Equal(6, ShapeAreaCalculator.CalculateArea(shape), 10);
    }

    [Fact]
    public void ShapeAreaCalculator_ThrowsForInvalidTriangle()
    {
        IShape shape = new Triangle(1, 2, 10);
        Assert.Throws<InvalidOperationException>(() => ShapeAreaCalculator.CalculateArea(shape));
    }
}