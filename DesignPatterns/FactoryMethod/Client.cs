namespace DesignPatterns;

public class Client
{
    public void Main()
    {
        Console.WriteLine("Glowna aplikacja: proba dzialania z uzyciem Manuala.");
        ClientCode(new ManualCarFactory());
        
        Console.WriteLine("-----------------------------------------------------------------------");

        Console.WriteLine("Glowna aplikacja: proba dzialania z uzyciem Automata.");
        ClientCode(new AutomaticCarFactory());
    }

    public void ClientCode(CarFactory carFactory)
    {
        Console.WriteLine("Client (uzywa obiektu typu CarFactory): " + carFactory.Operation() );
    }
}