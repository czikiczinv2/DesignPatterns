using DesignPatterns.AbstractFactory.AbstractProducts;

namespace DesignPatterns.AbstractFactory.ConcreteProducts;

public class SportsCarPeugeot : IPeugeotCar
{
    public string Drive()
    {
        return "Driving a Peugeot Sports Car";
    }
}