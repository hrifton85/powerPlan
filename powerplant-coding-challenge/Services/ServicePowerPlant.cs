using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using powerplant_coding_challenge.Controllers;
using powerplant_coding_challenge.DAO;
using powerplant_coding_challenge.Models;
using System;
using System.Collections.Generic;
using System.Reflection;


namespace powerplant_coding_challenge.Services
{
    public class ServicePowerPlant
    {
       private readonly ILogger<ServicePowerPlant> _logger;
        private readonly ProductionCalculator _productionCalculator;

        public ServicePowerPlant(ILogger<ServicePowerPlant>  logger, ProductionCalculator productionCalculator)
        {            
            _logger = logger;
            _productionCalculator = productionCalculator;
        }


        public List<PowerPlantResponse> CalculateProductionPlan(Payload payload)
        {

            _logger.LogInformation($"{GetType().Name}: CalculateProductionPlan");

            return _productionCalculator.CalculateProduction(payload);

         
        }      
    }

}
