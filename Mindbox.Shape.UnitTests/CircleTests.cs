using Mindbox.Shape.Core.Models;

namespace Mindbox.Shape.UnitTests;

public class CircleTests
{
    [Fact]
    public void CircleArea_IsCorrect()
    {
        var circle = new Circle(3);
        Assert.Equal(Math.PI * 9, circle.CalculateArea(), 10);
    }

    [Fact]
    public void Circle_IsValid_TrueForPositiveRadius()
    {
        var circle = new Circle(5);
        Assert.True(circle.IsValid());
    }

    [Fact]
    public void Circle_IsValid_FalseForZeroOrNegativeRadius()
    {
        var circle = new Circle(0);
        Assert.False(circle.IsValid());

        circle = new Circle(-5);
        Assert.False(circle.IsValid());
    }
}