using System.Diagnostics.CodeAnalysis;

namespace DataStructure.LinkedLists;

public class LinkedList<T>
{
    public Node<T>? _root;

    // 1. Collection mit 0 Elementen
    // 2. Collection mit einem Element
    // 3. Collection mit mehreren Elementen
    public void Insert(T data)
    {
        if(_root is null)
        {
            _root = new Node<T>(data);
            return;
        }
        Insert(data, _root);
    }

    private void Insert(T data, [NotNull] Node<T> node)
    {
        if (node.Next is null)
        {
            node.Next = new Node<T>(data);
            return;
        }
        Insert(data, node.Next);
    }

    public int Count()
    {
        if (_root is null)
        {
            return 0;
        }
        return Count(_root);
    }
    private int Count([NotNull] Node<T> node)
    {
        if (node.Next is null)
        {
            return 1;
        }
        return 1 + Count(node.Next);
    }
    
    // [4,2,3,3,2,3] => [4,2,2]
    // Delete (T data)
    
    public void Delete(T data)
    {
        if(_root.Next is null)
        {
            return;
        }
        Delete(_root, _root.Next, data);
    }
    private void Delete(Node<T> previous, Node<T> current, T data)
    {
        if (current.Data.Equals(data))
        {
            previous.Next = current.Next;
            return;
        }
        Delete(current, current.Next, data);
    }
}

// Wenn zwei Methoden mit gleichem Namen: Methoden überladen