class Program
{
    public static void Main(string[] args)
    {
        Plane plane = new("PlaneText", new Engine("Powerly123", 3), 5.5);
        Helicopter helicopter = new("Helium", new Engine("RoTaCo", 5), 4);

        List<FlyingMachine> flyingMachines = new() { plane, helicopter };
        List<FlyingMachine> copiedFlyingMachines = new();

        foreach (FlyingMachine flyingMachine in flyingMachines)
        {
            FlyingMachine copiedFlyingMachine = flyingMachine.Clone();
            copiedFlyingMachine.Fly();
            copiedFlyingMachines.Add(copiedFlyingMachine);
        }
    }
}
