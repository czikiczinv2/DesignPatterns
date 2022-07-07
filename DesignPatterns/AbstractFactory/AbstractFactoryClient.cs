namespace DesignPatterns.AbstractFactory;

public class AbstractFactoryClient
{
    public void Main()
    {
        Console.WriteLine("Main App: Sports Car Factory Test");
        ClientCode(new SportsCarFactory());

        Console.WriteLine("--------------------------------------------------------------------------------");
        
        Console.WriteLine("Main App: Truck Factory Test");
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