namespace APBD3;

public class GasContainer : Container
{
    public override string ContainerType { get; } = "G";
    public override void Empty()
    {
        MassOfLoad *= MassOfLoad;
    }
}