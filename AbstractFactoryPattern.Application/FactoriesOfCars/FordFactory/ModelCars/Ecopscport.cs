using AbstractFactoryPattern.Application.ModelCars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Application.ModelCars
{
    public class Ecopscport : ISuv
    {
        public string BuildSuvCar()
        {
            return "Ford - SUV - Ecopscport";
        }
    }
}
