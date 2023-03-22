namespace DataStructureTest;

public class LinkedListTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestInsertAndCount()
    {
        var list = new DataStructure.LinkedLists.LinkedList<int>();
        
        Assert.That(list.Count(), Is.EqualTo(0));
        
        list.Insert(3);
        list.Insert(4);
        list.Insert(2);
        
        Assert.That(list.Count(), Is.EqualTo(3));
    }

    [Test]
    public void TestDelete()
    {
        
    }
}