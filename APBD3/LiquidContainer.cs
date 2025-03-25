namespace APBD3;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool HazardousCargo { get; private set; }
    private readonly List<IHazardListener> _hazardListeners = new();
    public override void Load(double mass)
    {
        if ((HazardousCargo && mass >= 0.5 * Capacity) || mass >= 0.9 * Capacity)
            ((IHazardNotifier) this).Send("Too much cargo", SerialNumber);
        base.Load(mass);
    }
    
    public void AddListener(IHazardListener listener) => _hazardListeners.Add(listener);
    public IEnumerable<IHazardListener> GetListeners() => _hazardListeners;
}