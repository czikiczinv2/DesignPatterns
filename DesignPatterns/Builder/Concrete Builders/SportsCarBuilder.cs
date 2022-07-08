namespace DesignPatterns.Builder;

public class SportsCarBuilder : CarBuilder
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

    public override void BuildRadio()
    {
        _car.Add("Sports Car nie implementuje radia");
    }


    public override void BuildTurbo()
    {
        _car.Add("Turbo");
    }

    public override void BuildSpoiler()
    {
        _car.Add("Spoiler");
    }

    public Car GetResult()
    {
        return _car;
    }
    
}