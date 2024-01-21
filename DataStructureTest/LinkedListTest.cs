namespace DataStructureTest;

using DataStructure.LinkedLists;

public class LinkedListTest
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void TestInsertAndCount()
    {
        var list = new SinglyLinkedList<int>();
        Assert.That(list.Count(), Is.EqualTo(0));
        
        list.Insert(3);
        list.Insert(4);
        list.Insert(2);
        Assert.That(list.Count(), Is.EqualTo(3));

        var doublyList = new DoublyLinkedList<int>();
        Assert.That(doublyList.Count(), Is.EqualTo(0));

        doublyList.Insert(3);
        doublyList.Insert(4);
        doublyList.Insert(2);
        Assert.That(list.Count(), Is.EqualTo(3));
        
        Assert.That(doublyList._root.Next, Is.EqualTo(doublyList._root.Next.Next.Prev));
    }

    [Test]
    public void TestDelete()
    {
        
    }
}