namespace DesignPatterns.Decorator.ConcreteDecorators;

public class Buyable : Decorator
{
    public Buyable(CarShop carShop) : base(carShop)
    {
    }

    public override string Status()
    {
        return $"Buyable({base.Status()})";
    }
}