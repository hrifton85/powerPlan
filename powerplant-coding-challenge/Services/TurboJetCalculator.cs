using powerplant_coding_challenge.Interfaces;
using powerplant_coding_challenge.Models;

namespace powerplant_coding_challenge.Services
{
    public class TurboJetCalculator : IPowerPlantCalculator
    {
        public decimal CalculatePower(PowerPlant item, decimal load, Fuel fuels)
        {
            return Math.Min(item.Pmax, Math.Max(item.Pmin, load / item.Efficiency));
        }
    }
}
