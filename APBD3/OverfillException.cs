namespace APBD3;

public class OverfillException : Exception
{
    public OverfillException()
        : base(message: "Mass of cargo exceeded the capacity of the container")
    {
    }
}