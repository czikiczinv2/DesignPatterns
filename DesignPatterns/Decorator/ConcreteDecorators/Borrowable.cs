namespace DesignPatterns.Decorator.ConcreteDecorators;

public class Borrowable : Decorator
{
    public Borrowable(CarShop carShop) : base(carShop)
    {
    }

    public override string Status()
    {
        return $"Borrowable({base.Status()})";
    }
}