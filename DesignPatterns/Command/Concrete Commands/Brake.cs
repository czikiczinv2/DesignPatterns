namespace DesignPatterns.Command;

public class Brake : ICommand
{
    private Car _car;
    
    private string _action;

    public Brake(Car car, string action)
    {
        _car = car;
        _action = action;
    }
    
    public void Action()
    {
        Console.WriteLine("Action: Braking");
        _car.Brake(_action);
    }
}