namespace APBD3;

public class FreezerContainer : Container
{
    public string ProductType { get; set; } = string.Empty;
    public double Temperature { get; set; }
    public override string ContainerType { get; } = "C";
}