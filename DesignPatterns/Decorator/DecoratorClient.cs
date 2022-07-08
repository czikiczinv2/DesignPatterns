using DesignPatterns.Builder;
using DesignPatterns.Decorator.ConcreteDecorators;

namespace DesignPatterns.Decorator;

public class DecoratorClient
{
    public void Main()
    {
        var sportsCar = new SportsCar();
        Console.WriteLine("Client: I get an ordinary Sports Car");
        ClientCode(sportsCar);

        Console.WriteLine("--------------------------------------------------------------------------------");
        
        Buyable buyableSportsCar = new Buyable(sportsCar);
        Borrowable borrowableSportsCar = new Borrowable(sportsCar);
        Console.WriteLine("Client: Now I have a buyable Sports Car and borrowable Sports Car:");
        ClientCode(buyableSportsCar);
        ClientCode(borrowableSportsCar);
        
        Console.WriteLine("--------------------------------------------------------------------------------");

        Console.WriteLine("You can have multiple decorators of the same type on one concrete component:");
        Buyable buyablex2SportsCar = new Buyable(buyableSportsCar);
        ClientCode(buyablex2SportsCar);
    }
    
    
    public void ClientCode(CarShop carShop)
    {
        Console.WriteLine("Client: " + carShop.Status());
    }
}