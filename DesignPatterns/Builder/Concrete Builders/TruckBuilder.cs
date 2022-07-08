namespace DesignPatterns.Builder;

public class TruckBuilder : CarBuilder
{
    private readonly Car _car = new Car();
    
    public override void BuildEngineAndInterior()
    {
        _car.Add("Engine and Interior");
    }

    public override void BuildWheels()
    {
        _car.Add("Wheels");
    }

    public override void BuildTires()
    {
        _car.Add("Tires");
    }

    public override void BuildSteeringWheel()
    {
        _car.Add("Steering Wheel");
    }

    public override void BuildCarBody()
    {
        _car.Add("CarBody");
    }
    
    
    

    public override void BuildTrailer()
    {
        _car.Add("Trailer");
    }

    public Car GetResult()
    {
        return _car;
    }
}