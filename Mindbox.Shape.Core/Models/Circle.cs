using Mindbox.Shape.Core.Interfaces;

namespace Mindbox.Shape.Core.Models;

public class Circle(double radius) : IShape
{
    private double Radius { get; } = radius;

    public double CalculateArea() => Math.PI * Radius * Radius;

    public bool IsValid() => Radius > 0;
}