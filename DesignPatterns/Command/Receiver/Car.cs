namespace DesignPatterns.Command;

public class Car
{
    public void Drive(string action)
    {
        Console.WriteLine($"Car: {action}");
    }
    
    public void Brake(string action)
    {
        Console.WriteLine($"Car: {action}");
    }
    
    public void Honk(string action)
    {
        Console.WriteLine($"Car: {action}");
    }
}