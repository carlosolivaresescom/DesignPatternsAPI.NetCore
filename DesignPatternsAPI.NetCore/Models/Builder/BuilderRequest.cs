using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace DesignPatternsAPI.NetCore.Models
{
    [DataContract]
    public class BuilderRequest
    {
        public string Name { get; set; }

        public string Model { get; set; }


    }
}
