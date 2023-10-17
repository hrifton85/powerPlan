using powerplant_coding_challenge.DAO;
using powerplant_coding_challenge.Interfaces;
using powerplant_coding_challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace powerplant_coding_challenge.Services
{

    public class ProductionCalculator
        {
        private readonly IPowerPlantCalculatorFactory _calculatorFactory;
        private readonly ILogger<ProductionCalculator> _logger;
        public ProductionCalculator(IPowerPlantCalculatorFactory calculatorFactory, ILogger<ProductionCalculator> logger)
        {
            _calculatorFactory = calculatorFactory;
            _logger = logger;
        }
        public List<PowerPlantResponse> CalculateProduction(Payload payload)
            {
            _logger.LogInformation($"{GetType().Name}:Début du calcul de la production d'énergie.");
            decimal load = payload.Load;
                Fuel fuels = payload.Fuels;
                IEnumerable<PowerPlant> powerPlants = payload.PowerPlants;

                List<PowerPlantResponse> productionPlan = powerPlants.Select(item =>
                {
                    decimal power = CalculatePower(item, load, fuels);

                    return new PowerPlantResponse
                    {
                        Name = item.Name,
                        Power = power
                    };
                }).ToList();
            _logger.LogInformation("Calcul de la production d'énergie terminé.");
            return productionPlan;
            }

            private decimal CalculatePower(PowerPlant item, decimal load, Fuel fuels)
            {
            
            IPowerPlantCalculator calculator = _calculatorFactory.GetCalculator(item.Type);
            var results= calculator.CalculatePower(item, load, fuels);
            _logger.LogInformation($"Calcul de puissance pour {item.Name} (Type: {item.Type}): {results} MW");

            return results;
        }
        }
    
}
