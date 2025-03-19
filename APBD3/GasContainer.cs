namespace APBD3;

public class GasContainer : Container
{
    public override void Empty()
    {
        MassOfLoad *= MassOfLoad;
    }
}