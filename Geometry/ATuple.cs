namespace Geometry;

public abstract class ATuple
{
    public int X { get; set; }
    public int Y { get; set; }

    public ATuple()
    {
        
    }

    public ATuple(int x, int y)
    {
    }
    
    protected bool Equals(ATuple other)
    {
        return X == other.X && Y == other.Y;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(null, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ATuple)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
    
    public abstract int DetermineMagnitude();
}