using System;

public abstract class Shape
{
    public abstract float CalcultateArea();
}

public class Rectangle : Shape
{
    public float Width;
    public float Height;

    public override float CalcultateArea()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public float Radius;

    public override float CalcultateArea()
    {
        return MathF.PI * MathF.Pow(Radius, 2);
    }
}

public class AreaCalculator
{
    public float GetArea(Shape shape)
    {
        return shape.CalcultateArea();
    }
}