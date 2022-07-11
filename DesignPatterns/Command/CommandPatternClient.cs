namespace DesignPatterns.Command;

public class CommandPatternClient
{
    public void Main()
    {
        var invoker = new Invoker();
        invoker.SetCommand(new Drive(new Car(), "Car is driving"));
        invoker.SetAnotherCommand(new Brake(new Car(), "Car is braking"));
        
        invoker.ExecuteCommands();
    }

}