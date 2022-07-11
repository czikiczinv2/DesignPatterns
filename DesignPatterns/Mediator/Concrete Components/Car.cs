namespace DesignPatterns.Mediator;

public class Car : BaseComponent
{
    public void Brake()
    {
        Console.WriteLine("The car brakes");
        
        _mediator.Operation(this, "The car stopped");
    }

    public void Drive()
    {
        Console.WriteLine("The car is coming");
        
        _mediator.Operation(this, "The car is coming");
    }
}