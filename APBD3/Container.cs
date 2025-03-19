namespace APBD3;

public abstract class Container
{
    public double MassOfLoad { get; set; }
    public double Height { get; set; }
    public double OwnMass { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; } = string.Empty;
    public double Capacity { get; set; }
    
    public void Empty() => MassOfLoad = 0;
    public virtual void Load(double mass)
    {
        if (mass > Capacity)
        {
            throw new OverfillException();
        }
        MassOfLoad = mass;
    }
}