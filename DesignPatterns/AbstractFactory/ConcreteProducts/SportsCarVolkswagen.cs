using DesignPatterns.AbstractFactory.AbstractProducts;

namespace DesignPatterns.AbstractFactory.ConcreteProducts;

public class SportsCarVolkswagen : IVolkswagenCar
{
    public string Drive()
    {
        return "Driving a Volkswagen Sports Car";
    }
}