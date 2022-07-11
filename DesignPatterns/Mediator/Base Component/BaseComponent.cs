namespace DesignPatterns.Mediator;

public class BaseComponent
{
    protected IMediator _mediator;

    protected BaseComponent(IMediator mediator = null)
    {
        _mediator = mediator;
    }

    public void SetController(IMediator mediator)
    {
        _mediator = mediator;
    }
}