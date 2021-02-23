using AbstractFactoryPattern.Application.Factories.Interfaces;
using AbstractFactoryPattern.Application.ModelCars;
using AbstractFactoryPattern.Application.ModelCars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Application.Factories
{
    public class FordFactory : IAbstactFactoryBase
    {
        public IHatch CreateHatchModel()
        {
            return new Ka();
        }

        public ISedan CreateSedanModel()
        {
            return new Fusion();
        }

        public ISuv CreateSuvModel()
        {
            return new Ecopscport();
        }
    }
}
