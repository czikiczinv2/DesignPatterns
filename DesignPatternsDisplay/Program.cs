// See https://aka.ms/new-console-template for more information

using DesignPatterns;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.Command;
using DesignPatterns.Decorator;

Console.WriteLine("Factory Method Pattern:");

new FactoryMethodClient().Main();

Console.WriteLine("================================================================================");

Console.WriteLine("Abstract Factory Pattern:");

new AbstractFactoryClient().Main();

Console.WriteLine("================================================================================");

Console.WriteLine("Builder Pattern:");

new BuilderClient().Main();

Console.WriteLine("================================================================================");

Console.WriteLine("Decorator Pattern:");

new DecoratorClient().Main();

Console.WriteLine("================================================================================");

Console.WriteLine("Command Pattern:");

new CommandPatternClient().Main();