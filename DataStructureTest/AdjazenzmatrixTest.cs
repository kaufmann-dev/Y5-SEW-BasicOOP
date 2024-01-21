using DataStructure.Adjazenzmatrix;

namespace DataStructureTest;

public class AdjazenzmatrixTest
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void AddNode_AddsNodeToList()
    {
        var matrix = new Adjazenzmatrix(3);
        matrix.AddNode("A");
        matrix.AddNode("B");
        matrix.AddNode("C");

        Assert.That(matrix.NodeList[0], Is.EqualTo("A"));
        Assert.That(matrix.NodeList[1], Is.EqualTo("B"));
        Assert.That(matrix.NodeList[2], Is.EqualTo("C"));
    }

    [Test]
    public void AddEdge_AddsEdgeToAdjacencyMatrix()
    {
        var matrix = new Adjazenzmatrix(3);
        matrix.AddNode("A");
        matrix.AddNode("B");
        matrix.AddNode("C");

        matrix.AddEdge("A", "B", 2);
        matrix.AddEdge("B", "C", 3);

        Assert.That(matrix.AdjacencyMatrix[0, 1], Is.EqualTo(2));
        Assert.That(matrix.AdjacencyMatrix[1, 2], Is.EqualTo(3));
    }

    [Test]
    public void GetIndex_ReturnsCorrectIndex()
    {
        var matrix = new Adjazenzmatrix(3);
        matrix.AddNode("A");
        matrix.AddNode("B");
        matrix.AddNode("C");

        Assert.That(matrix.GetIndex("B"), Is.EqualTo(1));
    }
}