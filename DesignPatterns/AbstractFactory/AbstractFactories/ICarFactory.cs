using DesignPatterns.AbstractFactory.AbstractProducts;

namespace DesignPatterns.AbstractFactory;

public interface ICarFactory
{
    IPeugeotCar CreatePeugeotCar();
    IVolkswagenCar CreateVolkswagenCar();
}