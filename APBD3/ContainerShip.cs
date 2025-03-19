namespace APBD3;

public class ContainerShip
{
    public Dictionary<string, Container> Containers { get; } = new();
    public double MaxSpeed { get; set; }
    public double MaxContainerNumber { get; set; }

    public double CargoMass
    {
        get
        {
            double mass = 0;
            foreach (var keyValuePair in Containers.AsEnumerable())
            {
                mass += keyValuePair.Value.Mass;
            }
            return mass;
        }
    }

    public double Capacity { get; set; }

    public override string ToString() =>
        $"MaxSpeed: {MaxSpeed}, Containers: {Containers.Count}/Max: {MaxContainerNumber}, CargoMass: {CargoMass}/{Capacity}";

    public void Load(Container container)
    {
        if (CargoMass + container.Mass > Capacity)
            throw new OverfillException();
        Containers[container.SerialNumber] = container;
    }

    public void Load(IEnumerable<Container> containers)
    {
        foreach (var container in containers)
        {
            Load(container);       
        }
    }
}