namespace APBD3;

public class LiquidContainer : Container
{
    public bool HazardousCargo { get; private set; }

    public override void Load(double mass)
    {
        if ((HazardousCargo && mass >= 0.5 * Capacity) || mass >= 0.9 * Capacity)
            Console.WriteLine("Notify");
        base.Load(mass);
    }
}