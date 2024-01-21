namespace Geometry;

public class Point : ATuple
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point() : base()
    {
        
    }
    public Point(int x, int y) : base(x, y)
    {
        X = x;
        Y = y;
    }

    public override int DetermineMagnitude()
    {
        throw new NotImplementedException();
    }
}