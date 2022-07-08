using DesignPatterns.Builder.Directors;

namespace DesignPatterns.Builder;

public class BuilderClient
{
    public void Main()
    {
        var director = new Mechanic();
        
        Console.WriteLine("Main App: Director uses Sports Car Builder to create a Sports Car");
        var sportsCarBuilder = new SportsCarBuilder();
        director.Builder = sportsCarBuilder;
        
        director.BuildSportsCar();
        sportsCarBuilder.GetResult().DisplayParts();

        Console.WriteLine("--------------------------------------------------------------------------------");

        Console.WriteLine("Main App: Director uses Truck Builder to create a Truck");
        var truckBuilder = new TruckBuilder();
        director.Builder = truckBuilder;
        
        director.BuildTruck();
        truckBuilder.GetResult().DisplayParts();
        
        Console.WriteLine("--------------------------------------------------------------------------------");

        Console.WriteLine("Main App: Sports Car Builder creates a Sports Car on its own");
        var sportsCar = new SportsCarBuilder();
        sportsCar.BuildSteeringWheel();
        sportsCar.BuildWheels();
        sportsCar.BuildEngineAndInterior();
        sportsCar.BuildTires();
        sportsCar.BuildCarBody();
        sportsCar.BuildTurbo();
        sportsCar.BuildSpoiler();
        sportsCar.GetResult().DisplayParts();

    }
}