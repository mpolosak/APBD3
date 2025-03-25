namespace APBD3;

public interface IHazardNotifier
{ 
    public void AddListener(IHazardListener listener);

    public void Send(string message, string serialNumber)
    {
        foreach (var listener in GetListeners())
        {
            listener.Listen("Too much gas", serialNumber);
        }
    }

    protected IEnumerable<IHazardListener> GetListeners();
}