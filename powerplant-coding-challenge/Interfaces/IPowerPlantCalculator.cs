using powerplant_coding_challenge.Models;

namespace powerplant_coding_challenge.Interfaces
{
    public interface IPowerPlantCalculator
    {
        decimal CalculatePower(PowerPlant item, decimal load, Fuel fuels);
    }
}