using DesignPatterns.AbstractFactory.AbstractProducts;
using DesignPatterns.AbstractFactory.ConcreteProducts;

namespace DesignPatterns.AbstractFactory;

public class TruckFactory : ICarFactory
{
    public IPeugeotCar CreatePeugeotCar()
    {
        return new TruckPeugeot();
    }

    public IVolkswagenCar CreateVolkswagenCar()
    {
        return new TruckVolkswagen();
    }
}