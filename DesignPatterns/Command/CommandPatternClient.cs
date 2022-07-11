namespace DesignPatterns.Command;

public class CommandPatternClient
{
    public void Main()
    {
        var invoker = new Invoker();
        var invoker2 = new Invoker();
        
        var receiver = new Car();
        invoker.SetCommand(new Drive(receiver, "Car is driving"));
        invoker2.SetCommand(new Honk(receiver, "Car is honking"));
        invoker.SetAnotherCommand(new Brake(receiver, "Car is braking"));
        
        
        invoker.ExecuteCommands();
        invoker2.ExecuteCommands();
    }

}