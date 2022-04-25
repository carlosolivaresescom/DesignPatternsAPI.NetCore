using DesignPatternsAPI.NetCore.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsAPI.NetCore.Services;
using DesignPatternsAPI.NetCore.Models;

namespace DesignPatternsAPI.NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuilderController : ControllerBase
    {

        private readonly IBuilder _builder;

        public BuilderController()
        {
            _builder = new Builder();
        }

        [HttpGet]
        public string Get()
        {
            return "It is the responsible for creating objects \n" +
                "It separates the representation of the object with its creation.";
        }

        /// <summary>
        /// Create a new object using builder design pattern.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public string Post([FromBody]BuilderRequest request)
        {
            return _builder.BuildCar(request.Name, request.Model);
        }
    }
}
