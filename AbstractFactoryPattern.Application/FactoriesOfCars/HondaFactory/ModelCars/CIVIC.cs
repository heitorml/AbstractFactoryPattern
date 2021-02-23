﻿using AbstractFactoryPattern.Application.ModelCars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Application.FactoriesOfCars.HondaFactory.ModelCars
{
    public class CIVIC : ISedan
    {
        public string BuildSedanCars()
        {
            return "HONDA - Sedan - CIVIC";
        }
    }
}
