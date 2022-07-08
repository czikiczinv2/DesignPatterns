namespace DesignPatterns.Decorator;

public abstract class Decorator : CarShop
{
    protected CarShop _carShop;

    public Decorator(CarShop carShop)
    {
        _carShop = carShop;
    }

    public override string Status()
    {
        if (_carShop != null)
        {
            return _carShop.Status();
        }
        else
        {
            return String.Empty;
        }
    }

}