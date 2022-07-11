namespace DesignPatterns.Mediator;

public class Pedestrian : BaseComponent
{
    public void WalkOnToRoad()
    {
        Console.WriteLine("Pedestrian walks onto road ");
        
        _mediator.Operation(this, "Pedestrian on the road");
    }

    public void Wait()
    {
        Console.WriteLine("Pedestrian waits for the car to pass");
        
        _mediator.Operation(this, "Pedestrian waits for the car to pass");
    }

}