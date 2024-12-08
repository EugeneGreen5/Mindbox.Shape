using Mindbox.Shape.Core.Interfaces;

namespace Mindbox.Shape.Core;

public class ShapeAreaCalculator
{
    public static double CalculateArea(IShape shape)
    {
        if (!shape.IsValid())
            throw new InvalidOperationException("Invalid shape dimensions.");
        
        return shape.CalculateArea();
    }
}