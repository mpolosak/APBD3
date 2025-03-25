namespace APBD3;

public abstract class Container
{
    public double MassOfLoad { get; set; }
    public double Height { get; set; }
    public double OwnMass { get; set; }

    public double Mass => MassOfLoad + OwnMass;
    public double Depth { get; set; }

    public string SerialNumber
    {
        get => $"KON-{ContainerType}-{ID}";
    }
    public abstract string ContainerType { get; }
    
    public double Capacity { get; set; }
    
    public virtual void Empty() => MassOfLoad = 0;
    static int _counter = 0;
    int ID { get; } = _counter++;
    public virtual void Load(double mass)
    {
        if (mass > Capacity)
        {
            throw new OverfillException();
        }
        MassOfLoad = mass;
    }
}