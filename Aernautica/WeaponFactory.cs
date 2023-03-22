namespace Aernautica;

public class WeaponFactory : IWeaponFactory
{
    public static WeaponFactory Instance { get; } = new();

    private WeaponFactory()
    {
        
    }

    public Weapon CreateQuadAutoCannon()
    {
        var builder = new Weapon.WeaponBuilder();
        
        builder
            .SetName("Quad Autocannon")
            .SetFireArc(EFireArc.FRONT)
            .AddRange(ERangeType.SHORT, 2)
            .AddRange(ERangeType.MEDIUM, 6)
            .AddRange(ERangeType.LONG, 0)
            .SetDamage(4)
            .SetAmmunition(-1);
        
        return builder.Build();
    }

    public Weapon CreateTwinLasCannon()
    {
        var builder = new Weapon.WeaponBuilder();
        
        builder
            .SetName("Twin Lascannon")
            .SetFireArc(EFireArc.FRONT)
            .AddRange(ERangeType.SHORT, 0)
            .AddRange(ERangeType.MEDIUM, 2)
            .AddRange(ERangeType.LONG, 1)
            .SetDamage(2)
            .SetAmmunition(-1);
        
        return builder.Build();
    }
}

// singleton: immer nur eine instanz darf existieren
// speichermanagement
// man soll von überall zugreifen können, ohne an konstruktor an klasse zu übergeben
// thread safe

// publc static ist problematisch
// um auf objektvaraible braucht man objekt
// für objekt aber geht nix weil private
// static: instant hängt an, alles wird klassenobjekt zugeordnet
// für jee klasse 1 klassenobjekt
// auf klaasenobjekt imer zugreifen
// zugriff: klaasenname.feldname.methode
// klassenobjekt geladen wenn von klassenlader geladen