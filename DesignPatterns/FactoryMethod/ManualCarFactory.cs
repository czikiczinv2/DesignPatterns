namespace DesignPatterns;

public class ManualCarFactory : CarFactory
{
    public override ICar Create()
    {
        return new Manual();
    }
}