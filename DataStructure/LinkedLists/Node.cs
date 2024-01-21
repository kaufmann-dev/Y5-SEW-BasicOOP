﻿namespace DataStructure.LinkedLists;

public class Node<T>
{
    public T Data { get; set; }
    public Node<T>? Prev { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T data)
    {
        Data = data;
    }
}