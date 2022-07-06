namespace DesignPatterns;

public class AutomaticCarFactory : CarFactory
{
    public override ICar Create()
    {
        return new Automatic();
    }
}