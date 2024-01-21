namespace DataStructure.BinaryTrees;

public class BinaryTree<T> where T : IComparable<T>
{
    private Node<T>? _root;

    public void Insert(T data)
    {
        if(_root == null)
        {
            _root = new Node<T>(data);
            return;
        }
        Insert(data, _root);
    }

    private void Insert(T data, Node<T> node)
    {
        if(data.CompareTo(node.Data) < 0)
        {
            if(node.Left is null)
            {
                node.Left = new Node<T>(data);
                return;
            }
            Insert(data, node.Left);
        }
        else
        {
            if(node.Right is null)
            {
                node.Right = new Node<T>(data);
                return;
            }
            Insert(data, node.Right);
        }
    }

    public T Min()
    {
        if (_root is null)
        {
            return default;
        }
        else
        {
            return Min(_root);
        }
    }
    
    private T Min(Node<T> node)
    {
        if(node.Left is null)
        {
            return node.Data;
        }
        else
        {
            return Min(node.Left);
        }
    }
}