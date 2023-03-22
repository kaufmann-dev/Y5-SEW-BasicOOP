namespace Aernautica;

public class Weapon
{
    public string Name { get; init; }

    public EFireArc FireArc { get; init; }

    public Dictionary<ERangeType, int> Ranges { get; init; } = new();

    public int Ammunition { get; set; }

    public int Damage { get; init; }

    public Weapon()
    {
        
    }
    
    public class WeaponBuilder
    {
        private string _name;

        public WeaponBuilder SetName(string name)
        {
            _name = name;
            return this;
        }
        
        public WeaponBuilder SetDamage(int damage)
        {
            _damage = damage;
            return this;
        }

        public WeaponBuilder SetFireArc(EFireArc arc)
        {
            _fireArc = arc;
            return this;
        }

        public EFireArc GetArc() => _fireArc;

        public string GetName() => _name;

        private EFireArc _fireArc;

        private Dictionary<ERangeType, int> _ranges = new();

        public WeaponBuilder AddRange(ERangeType range, int damage)
        {
            _ranges[range] = damage;
            return this;
        }

        private int _ammunition;

        public WeaponBuilder SetAmmunition(int damage)
        {
            _damage = damage;
            return this;
        }

        private int _damage;

        public Weapon Build() => new Weapon()
        {
            Name = _name,
            FireArc = _fireArc,
            Ranges = _ranges,
            Ammunition = _ammunition,
            Damage = _damage
        };
    }
}