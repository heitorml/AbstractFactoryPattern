using AbstractFactoryPattern.Application.ModelCars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Application.FactoriesOfCars.HondaFactory.ModelCars
{
    public class FIT : IHatch
    {
        public string BuildHatchCars()
        {
            return "HONDA - Hatch - FIT";
        }
    }
}
