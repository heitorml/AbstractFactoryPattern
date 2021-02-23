using AbstractFactoryPattern.Application.Factories;
using AbstractFactoryPattern.Application.Factories.Interfaces;
using System;

namespace AbstractFactoryPattern.Application
{
    public class FactoryService
    {
        public void Main()
        {
            Console.WriteLine("Ford Factory : ");
            ClientMethod(new FordFactory());
            Console.WriteLine();
            Console.WriteLine("Toyota Factory : ");
            ClientMethod(new ToyotaFactory());
            Console.WriteLine();
            Console.WriteLine("Honda Factory  : ");
            ClientMethod(new HondaFactory());
        }
        public void ClientMethod(IAbstactFactoryBase factory)
        {
            var hatchCar = factory.CreateHatchModel();
            var sedanCar = factory.CreateSedanModel();
            var suvCar = factory.CreateSuvModel();

            Console.WriteLine(hatchCar.BuildHatchCars());
            Console.WriteLine(sedanCar.BuildSedanCars());
            Console.WriteLine(suvCar.BuildSuvCar());
        }
    }
}
