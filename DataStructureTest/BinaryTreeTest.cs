using DataStructure.BinaryTrees;

namespace DataStructureTest;

public class BinaryTreeTest
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void TestInsertAndMin()
    {
        var binaryTree = new BinaryTree<int>();
        
        binaryTree.Insert(25);
        binaryTree.Insert(15);
        binaryTree.Insert(50);
        binaryTree.Insert(10);
        binaryTree.Insert(22);
        
        Assert.That(binaryTree.Min(), Is.EqualTo(10));
    }
}