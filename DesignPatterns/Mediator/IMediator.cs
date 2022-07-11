namespace DesignPatterns.Mediator;

public interface IMediator
{
    public void Operation(object sender, string operation);
}