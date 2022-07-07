// See https://aka.ms/new-console-template for more information

using DesignPatterns;
using DesignPatterns.AbstractFactory;

Console.WriteLine("Factory Method Pattern:");

new FactoryMethodClient().Main();

Console.WriteLine("================================================================================");

Console.WriteLine("Abstract Factory Pattern:");

new AbstractFactoryClient().Main();