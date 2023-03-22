namespace Aernautica;

public class AircraftFactory : IAircraftFactory
{
    public Aircraft CreateThunderBolt() {
        
        var builder = new Aircraft.AircraftBuilder();
        var weaponFacotry = WeaponFactory.Instance;

        builder.SetName("Thunderbolt")
            .SetStructure(3)
            .SetTransport(0)
            .SetFuel(0)
            .SetThrottle(2)
            .SetManoeuvres(6)
            .SetCurrentSpeed(0)
            .SetMinSpeed(2)
            .SetMaxSpeed(6)
            .SetHandling(3)
            .AddWeapon(weaponFacotry.CreateQuadAutoCannon())
            .AddWeapon(weaponFacotry.CreateTwinLasCannon());

        return builder.Build();
    }
}