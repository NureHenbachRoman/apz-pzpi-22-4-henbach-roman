class Plane : FlyingMachine
{
    public double WingLength { get; }

    public Plane(string name, Engine engine, double wingLength) 
        : base(name, engine)
    {
        WingLength = wingLength;
    }

    public Plane(Plane other) : base(other)
    {
        WingLength = other.WingLength;
    }

    public override FlyingMachine Clone()
    {
        return new Plane(this);
    }

    public override void Fly()
    {
        Console.WriteLine("Plane " + name + " took off.");
    }
}
