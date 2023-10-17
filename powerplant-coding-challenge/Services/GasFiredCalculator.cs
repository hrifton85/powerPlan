using powerplant_coding_challenge.Interfaces;
using powerplant_coding_challenge.Models;

namespace powerplant_coding_challenge.Services
{
    public class GasFiredCalculator : IPowerPlantCalculator
    {
        public decimal CalculatePower(PowerPlant item, decimal load, Fuel fuels)
        {
            decimal gasPower = item.Pmax / item.Efficiency;
            return Math.Min(gasPower, item.Pmax);
        }
    }
}
