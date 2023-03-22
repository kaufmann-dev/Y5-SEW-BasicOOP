global using NUnit.Framework;
using Geometry;

namespace DomainTest;

public class PointTest
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void TestObjectDeclarationAndInitialization()
    {
        // es wird fälschlicherweise oft als Objekt bezeichnet
        // Referenz auf ein Objekt
        // Instanz der KLasse
        // Zeiger auf ein Objekt
        // Variable
        
        Point p1 = new Point();
        // new: Reserviert den Speicher für Objekt auf Heap
        Assert.That(p1.X, Is.EqualTo(0));
        Assert.That(p1.Y, Is.EqualTo(0));

        Point p2 = new Point(4, 5);
        Assert.That(p2.X, Is.EqualTo(4));
        Assert.That(p2.Y, Is.EqualTo(5));

        Point p3 = new(5, 1);
        Assert.That(p3.X, Is.EqualTo(5));
        Assert.That(p3.Y, Is.EqualTo(1));
        
        var p4 = new Point(5, 3);
        Assert.That(p4.X, Is.EqualTo(5));
        Assert.That(p4.Y, Is.EqualTo(3));

        var p5 = new Point() { X = 34, Y = 88 };
        Assert.That(p5.X, Is.EqualTo(34));
        Assert.That(p5.Y, Is.EqualTo(88));

        // Referenzgleichheit
        var p6 = p5;
        Assert.That(p6, Is.SameAs(p5));
        Assert.That(p6, Is.Not.SameAs(p4));
        Assert.True(p6 == p5);
        
        // Wertegleichheit
        var p7 = new Point() { X = 34, Y = 2 };
        Assert.That(p7, Is.EqualTo(p5));
        Assert.True(p7.Equals(p5));

        ATuple p8 = new Point(6, 8);
        Assert.That(p8.X, Is.EqualTo(6));
        Assert.That(p8.Y, Is.EqualTo(8));
        
    }

    [Test]
    public void TestObjectEqulity()
    {
        
    }
}