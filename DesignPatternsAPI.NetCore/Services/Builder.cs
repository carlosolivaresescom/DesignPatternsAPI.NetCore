using DesignPatternsAPI.NetCore.Models;
using DesignPatternsAPI.NetCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsAPI.NetCore.Services
{
    public class Builder : IBuilder
    {

        public string BuildCar(string name, string model)
        {
            Car car = CarBuilder.CreateNew().AddName(name).AddModel(model).Build();
            return $"This Car was created using Builder design pattern \n" +
                $"Name: {car.Name} \n" +
                $"Model: {car.Model}.";
        }

    }
}
