using DesignPatterns.AbstractFactory.AbstractProducts;
using DesignPatterns.AbstractFactory.ConcreteProducts;

namespace DesignPatterns.AbstractFactory;

public class SportsCarFactory : ICarFactory
{
    public IPeugeotCar CreatePeugeotCar()
    {
        return new SportsCarPeugeot();
    }

    public IVolkswagenCar CreateVolkswagenCar()
    {
        return new SportsCarVolkswagen();
    }
}