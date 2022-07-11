namespace DesignPatterns.Mediator;

public class ConcreteController : IMediator
{
    private Pedestrian _pedestrian;

    private Car _car;
    
    public ConcreteController(Pedestrian pedestrian, Car car)
    {
        _pedestrian = pedestrian;
        _pedestrian.SetController(this);
        _car = car;
        _car.SetController(this);
    }
    
    public void Operation(object sender, string operation)
    {
        switch (operation)
        {
            case "Pedestrian on the road":
                Console.WriteLine($"Controller: {operation}");
                _car.Brake();
                break;
            case "The car is coming":
                Console.WriteLine($"Controller: {operation}");
                _pedestrian.Wait();
                break;
        }
    }
}