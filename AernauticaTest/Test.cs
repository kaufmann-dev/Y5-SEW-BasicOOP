using NUnit.Framework;

namespace AernauticaUnittest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void WeaponFactory()
    {
        var factory = Aernautica.WeaponFactory.Instance;
        var factory2 = Aernautica.WeaponFactory.Instance;
        
        Assert.NotNull(factory);
        Assert.That(factory, Is.SameAs(factory2));
    }
    
    [Test]
    public void TestQuadCannonCreation()
    {
        var factory = Aernautica.WeaponFactory.Instance;
        var weapon = factory.CreateQuadAutoCannon();
        
        Assert.That(weapon.Name, Is.EqualTo("Quad Autocannon"));
        Assert.That(weapon.Damage, Is.EqualTo(4));
    }
}