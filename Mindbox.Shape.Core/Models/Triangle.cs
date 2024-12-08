using Mindbox.Shape.Core.Interfaces;

namespace Mindbox.Shape.Core.Models;

public class Triangle(double sideA, double sideB, double sideC) : IShape
{
    private double SideA { get; } = sideA;
    private double SideB { get; } = sideB;
    private double SideC { get; } = sideC;

    /// <summary>
    /// Вычисление площади треугольника через формулу Герона
    /// </summary>
    /// <returns>Площадь треугольника</returns>
    public double CalculateArea()
    {
        var semiPerimeter = (SideA + SideB + SideC) / 2; 
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC)); 
    }

    public bool IsValid() => SideA > 0 && SideB > 0 && SideC > 0 && SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;

    public bool IsRightTriangle()
    {
        double[] sides = [SideA, SideB, SideC];
        Array.Sort(sides);
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
    }
}