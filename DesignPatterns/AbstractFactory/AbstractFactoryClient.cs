namespace DesignPatterns.AbstractFactory;

public class AbstractFactoryClient
{
    public void Main()
    {
        Console.WriteLine("Glowna Aplikacja: Test fabryki samochodow sportowych");
        ClientCode(new SportsCarFactory());

        Console.WriteLine("--------------------------------------------------------------------------------");
        
        Console.WriteLine("Glowna Aplikacja: Test fabryki ciezarowek ");
        ClientCode(new TruckFactory());
    }

    public void ClientCode(ICarFactory factory)
    {
        var peugeot = factory.CreatePeugeotCar();
        var volkswagen = factory.CreateVolkswagenCar();
        
        Console.WriteLine(peugeot.Drive());
        Console.WriteLine(volkswagen.Drive());
        
    }
}