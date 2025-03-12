class Helicopter : FlyingMachine
{
    public int Blades { get; } 

    public Helicopter(string name, Engine engine, int blades) : base(name, engine)
    {
        Blades = blades;
    }

    public Helicopter(Helicopter other) : base(other)
    {
        Blades = other.Blades;
    }

    public override FlyingMachine Clone()
    {
        return new Helicopter(this);
    }

    public override void Fly()
    {
        Console.WriteLine("Helicopter " + name + " took off.");
    }
}
