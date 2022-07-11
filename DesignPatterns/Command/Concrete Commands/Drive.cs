namespace DesignPatterns.Command;

public class Drive : ICommand
{
    private Car _car;
    
    private string _action;

    public Drive(Car car, string action)
    {
        _car = car;
        _action = action;
    }
    
    public void Action()
    {
        Console.WriteLine("Action: Driving");
        _car.Drive(_action);
    }
}