using DesignPatterns.AbstractFactory.AbstractProducts;

namespace DesignPatterns.AbstractFactory.ConcreteProducts;

public class TruckVolkswagen : IVolkswagenCar
{
    public string Drive()
    {
        return "Driving a Volkswagen Truck";
    }
}