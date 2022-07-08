namespace DesignPatterns.Builder.Directors;

public class Mechanic
{
    private CarBuilder _builder = null!;

    public CarBuilder Builder
    {
        set => _builder = value;
    }

    public void BuildSimplestWorkingCar()
    {
        _builder.BuildSteeringWheel();
        _builder.BuildEngineAndInterior();
        _builder.BuildWheels();
        _builder.BuildTires();
        _builder.BuildCarBody();
    }

    public void BuildSportsCar()
    {
        BuildSimplestWorkingCar();
        _builder.BuildTurbo();
        _builder.BuildSpoiler();
    }

    public void BuildBasicCarWithRadio()
    {
        BuildSimplestWorkingCar();
        _builder.BuildRadio();
    }

    public void BuildTruck()
    {
        BuildSimplestWorkingCar();
        _builder.BuildTrailer();
    }
}