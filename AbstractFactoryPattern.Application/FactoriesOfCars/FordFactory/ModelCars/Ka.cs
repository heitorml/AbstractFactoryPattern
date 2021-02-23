using AbstractFactoryPattern.Application.ModelCars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Application.ModelCars
{
    public class Ka : IHatch
    {
        public string BuildHatchCars()
        {
            return "Ford - Hatch - KA";
        }
    }
}
