namespace Aernautica;

public class Aircraft
{
    
    
    public Dictionary<string, Weapon> Weapons = new();

    public int Structure { get; init; }

    public int Transport { get; init; }

    public int Fuel { get; init; }

    public int Throttle { get; init; }

    public int Manoeuvres { get; init; }

    public int Handling { get; init; }

    public int MinSpeed { get; init; }

    public int MaxSpeed { get; init; }

    public int CurrentSpeed { get; set; }

    public int MaxAltitude { get; init; }

    public class AircraftBuilder
    {
        private string _name;
        public AircraftBuilder SetName(string name)
        {
            _name = name;
            return this;
        }
        public AircraftBuilder AddWeapon(Weapon weapon, string value)
        {
            _weapons[value] = weapon;
            return this;
        }
        private Dictionary<string, Weapon> _weapons = new();
        public Weapon this[string key] => _weapons[key];
        
        public AircraftBuilder SetStructure(int structure)
        {
            _structure = structure;
            return this;
        }
        private int _structure;
        public int GetStructure()=>_structure;
        
        public AircraftBuilder SetTransport(int transport)
        {
            _transport = transport;
            return this;
        }
        private int _transport;
        public int GetTransport()=>_transport;
        
        public AircraftBuilder SetFuel(int fuel)
        {
            _fuel = fuel;
            return this;
        }
        private int _fuel;
        public int GetFuel()=>_fuel;
        
        public AircraftBuilder SetThrottle(int throttle)
        {
            _throttle = throttle;
            return this;
        }
        private int _throttle;
        public int GetThrottle()=>_throttle;
        
        public AircraftBuilder SetManoeuvres(int manoeuvres)
        {
            _manoeuvres = manoeuvres;
            return this;
        }
        private int _manoeuvres;
        public int GetManoeuvres()=>_manoeuvres;
        
        public AircraftBuilder SetHandling(int handling)
        {
            _handling = handling;
            return this;
        }
        private int _handling;
        public int GetHandling()=>_handling;
        
        public AircraftBuilder SetMinSpeed(int minSpeed)
        {
            _minSpeed = minSpeed;
            return this;
        }
        private int _minSpeed;
        public int GetMinSpeed()=>_minSpeed;
        
        public AircraftBuilder SetMaxSpeed(int maxSpeed)
        {
            _maxSpeed = maxSpeed;
            return this;
        }
        private int _maxSpeed;
        public int GetMaxSpeed()=>_maxSpeed;
        
        public AircraftBuilder SetCurrentSpeed(int currentSpeed)
        {
            _currentSpeed = currentSpeed;
            return this;
        }
        private int _currentSpeed;
        public int GetCurrentSpeed()=>_currentSpeed;
        
        public AircraftBuilder SetMaxAltitude(int maxAltitude)
        {
            _maxAltitude = maxAltitude;
            return this;
        }
        private int _maxAltitude;
        public int GetMaxAltitude()=>_maxAltitude;

        public Aircraft Build() => new Aircraft()
        {
            Structure = _structure,
            Transport = _transport,
            Fuel = _fuel,
            Throttle = _throttle,
            Manoeuvres = _manoeuvres,
            Handling = _handling,
            MinSpeed = _minSpeed,
            MaxSpeed = _maxSpeed,
            CurrentSpeed = _currentSpeed,
            MaxAltitude = _maxAltitude,
            Weapons = _weapons
        };
    }
}