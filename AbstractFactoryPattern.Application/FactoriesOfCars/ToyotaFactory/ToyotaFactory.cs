using AbstractFactoryPattern.Application.Factories.Interfaces;
using AbstractFactoryPattern.Application.FactoriesOfCars.ToyotaFactory.ModelCars;
using AbstractFactoryPattern.Application.ModelCars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Application.Factories
{
    public class ToyotaFactory : IAbstactFactoryBase
    {
        public IHatch CreateHatchModel()
        {
            return new Etios();
        }

        public ISedan CreateSedanModel()
        {
            return new Corolla();
        }

        public ISuv CreateSuvModel()
        {
            return new RAV04();
        }
    }
}
