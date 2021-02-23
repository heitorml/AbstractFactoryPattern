using AbstractFactoryPattern.Application.ModelCars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Application.ModelCars
{
    public class Fusion : ISedan
    {
        public string BuildSedanCars()
        {
            return "Ford - Sedan - Fusion";
        }
    }
}
