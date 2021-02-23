using AbstractFactoryPattern.Application.ModelCars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Application.FactoriesOfCars.ToyotaFactory.ModelCars
{
    public class Etios : IHatch
    {
        public string BuildHatchCars()
        {
            return "TOYOTA - Hatch - Etios";
        }
    }
}
