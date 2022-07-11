namespace DesignPatterns.Mediator;

public class MediatorPatternClient
{
    public void Main()
    {
        var car = new Car();
        var pedestrian = new Pedestrian();
        var controller = new ConcreteController(pedestrian, car);
        
        car.Drive();

        Console.WriteLine("--------------------------------------------------------------------------------");
        
        pedestrian.WalkOnToRoad();
    }
}