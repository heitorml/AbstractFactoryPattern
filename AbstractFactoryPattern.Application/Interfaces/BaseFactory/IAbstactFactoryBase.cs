using AbstractFactoryPattern.Application.ModelCars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Application.Factories.Interfaces
{
    public interface IAbstactFactoryBase
    {
        ISedan CreateSedanModel();
        ISuv CreateSuvModel();
        IHatch CreateHatchModel();
    }
}
