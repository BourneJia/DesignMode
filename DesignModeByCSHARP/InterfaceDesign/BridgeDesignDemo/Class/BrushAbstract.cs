using System;

public abstract class Brush
{
    protected Color color;

    public abstract void Paint();

    public void SetColor(Color _Color)
    {
        color = _Color;
    }    
}

public class BigBrush : Brush
{
    public override void Paint()
    {
        Console.WriteLine($"Using BigBrush and color {color.color} painting");
    }
}

public class SmallBrush : Brush
{
    public override void Paint()
    {
        Console.WriteLine($"Using SmallBrush and color {color.color} painting");
    }
}