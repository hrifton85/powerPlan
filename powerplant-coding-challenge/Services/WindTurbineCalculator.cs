using powerplant_coding_challenge.Interfaces;
using powerplant_coding_challenge.Models;

namespace powerplant_coding_challenge.Services
{
    public class WindTurbineCalculator : IPowerPlantCalculator
    {
        public decimal CalculatePower(PowerPlant item, decimal load, Fuel fuels)
        {
            return (fuels.Wind / 100) * item.Pmax;
        }
    }
}
