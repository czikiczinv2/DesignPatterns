namespace DesignPatterns.Command;

public class Honk : ICommand
{
    private Car _car;
    
    private string _action;

    public Honk(Car car, string action)
    {
        _car = car;
        _action = action;
    }
    
    public void Action()
    {
        Console.WriteLine("Action: Honking");
        _car.Honk(_action);
    }
}