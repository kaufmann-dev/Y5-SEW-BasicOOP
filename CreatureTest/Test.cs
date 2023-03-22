global using NUnit.Framework;
using Creatures;

namespace CreatureTest;

public class Tests {
    [SetUp]
    public void Setup() {
    }

    [Test]
    public void Test1() {
        var ork = new Creature(){Endurance = 10, CombatSkill = 45};
        
        Assert.That(ork.Endurance, Is.EqualTo(10));
        Assert.That(ork.CombatSkill, Is.EqualTo(45));
        
        
    }
}