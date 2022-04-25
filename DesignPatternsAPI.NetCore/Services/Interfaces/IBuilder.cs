using DesignPatternsAPI.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsAPI.NetCore.Services.Interfaces
{
    public interface IBuilder
    {
        string BuildCar(string name, string model);
    }
}
