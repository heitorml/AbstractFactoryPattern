using AbstractFactoryPattern.Application.ModelCars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Application.FactoriesOfCars.ToyotaFactory.ModelCars
{
    public class Corolla : ISedan
    {
        public string BuildSedanCars()
        {
            return "TOYOTA - Sedan - Corolla";
        }
    }
}
