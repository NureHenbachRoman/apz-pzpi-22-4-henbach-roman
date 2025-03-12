abstract class FlyingMachine
{
    public string name;
    protected Engine Engine { get; }

    public FlyingMachine(string name, Engine engine)
    {
        this.name = name;
        Engine = engine;
    }

    public FlyingMachine(FlyingMachine other)
    {
        name = other.name;
        Engine = other.Engine;
    }

    public abstract FlyingMachine Clone();

    public abstract void Fly();
}
