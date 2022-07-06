namespace DesignPatterns;

public abstract class CarFactory
{
    public abstract ICar Create();

    public string Operation()
    {
        var car = Create();

        var result = "CarFactory: " + car.Drive();

        return result;
    }
    
    
}