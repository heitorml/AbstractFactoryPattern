using AbstractFactoryPattern.Application.ModelCars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Application.FactoriesOfCars.HondaFactory.ModelCars
{
    public class SRV : ISuv
    {
        public string BuildSuvCar()
        {
            return "HONDA - SUV - SRV";
        }
    }
}
