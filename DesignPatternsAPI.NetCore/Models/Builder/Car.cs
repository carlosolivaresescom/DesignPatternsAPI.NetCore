using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsAPI.NetCore.Models
{
    public sealed class Car
    {
        public string Name;
        public string Model;

        public override string ToString()
        {
            return $"Mi car is {Name}, Model: {Model}";
        }
    }
}
