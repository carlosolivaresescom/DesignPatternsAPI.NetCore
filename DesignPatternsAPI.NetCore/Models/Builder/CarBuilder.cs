using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsAPI.NetCore.Models
{
    public class CarBuilder
    {
        private readonly Car _car;

        private CarBuilder()
        {
            _car = new Car();
        }

        public static CarBuilder CreateNew()
        {
            return new CarBuilder();
        }

        public CarBuilder AddName(string name)
        {
            _car.Name = name;
            return this;
        }

        public CarBuilder AddModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}
