namespace DataStructure.LinkedLists; 

public class DoublyLinkedList<T> where T : IComparable<T> {
    public Node<T>? _root;

    public void Insert(T data) {
        if (_root is null){
            _root = new Node<T>(data);
            return;
        }
        Insert(data, _root);
    }

    private void Insert(T data, Node<T> node) {
        if (node.Next is null){
            node.Next = new Node<T>(data) {
                Prev = node
            };
            return;
        }
        Insert(data, node.Next);
    }

    public int Count() {
        if (_root is null){
            return 0;
        }
        return Count(_root);
    }

    private int Count(Node<T> node) {
        if (node.Next is null)
        {
            return 1;
        }
        return 1 + Count(node.Next);
    }
    
    public void Delete(T data)
    {
        if(_root.Next is null)
        {
            return;
        }
        Delete(_root.Next, data);
    }

    private void Delete(Node<T> current, T data)
    {
        if (current.Data.Equals(data))
        {
            current.Prev.Next = current.Next;
            return;
        }
        Delete(current.Next, data);
    }
}