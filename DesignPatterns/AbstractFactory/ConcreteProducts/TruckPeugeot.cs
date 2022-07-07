using DesignPatterns.AbstractFactory.AbstractProducts;

namespace DesignPatterns.AbstractFactory.ConcreteProducts;

public class TruckPeugeot : IPeugeotCar
{
    public string Drive()
    {
        return "Driving a Peugeot Truck";
    }
}