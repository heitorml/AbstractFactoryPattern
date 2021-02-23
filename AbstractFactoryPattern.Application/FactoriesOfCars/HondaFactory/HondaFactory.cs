using AbstractFactoryPattern.Application.Factories.Interfaces;
using AbstractFactoryPattern.Application.FactoriesOfCars.HondaFactory.ModelCars;
using AbstractFactoryPattern.Application.ModelCars.Interfaces;

namespace AbstractFactoryPattern.Application.Factories
{
    public class HondaFactory : IAbstactFactoryBase
    {
        public IHatch CreateHatchModel()
        {
            return new FIT();
        }

        public ISedan CreateSedanModel()
        {
            return new CIVIC();
        }

        public ISuv CreateSuvModel()
        {
            return new SRV();
        }
    }
}
