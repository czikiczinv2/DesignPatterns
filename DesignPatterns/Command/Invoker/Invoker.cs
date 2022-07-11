namespace DesignPatterns.Command;

public class Invoker
{
    private ICommand _command;

    private ICommand _anotherCommand;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void SetAnotherCommand(ICommand anotherCommand)
    {
        _anotherCommand = anotherCommand;
    }

    public void ExecuteCommands()
    {
        Console.WriteLine("Invoker: Preparing to execute a command");

        if (_command != null)
        {
            _command.Action();
        }

        Console.WriteLine("Invoker: Preparing to perform another command");

        if (_anotherCommand != null)
        {
            _anotherCommand.Action();
        }
    }
}