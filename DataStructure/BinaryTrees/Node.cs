namespace DataStructure.BinaryTrees;

public class Node<T> where T : IComparable<T>
{
    public T Data { get; set; }
    public Node<T>? Left { get; set; }
    public Node<T>? Right { get; set; }

    public Node(T data)
    {
        Data = data;
    }
}

// a.CompareTo(b)
// a < b => -1
// a == b => 0
// a > b => 1