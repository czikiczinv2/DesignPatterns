namespace DesignPatterns;

public class FactoryMethodClient
{
    public void Main()
    {
        Console.WriteLine("Main App: Manual Car Factory Test");
        ClientCode(new ManualCarFactory());
        
        Console.WriteLine("--------------------------------------------------------------------------------");

        Console.WriteLine("Main App: Automatic Car Factory Test");
        ClientCode(new AutomaticCarFactory());
    }

    public void ClientCode(CarFactory carFactory)
    {
        Console.WriteLine("Client (receives an object of type CarFactory): " + carFactory.Operation() );
    }
}