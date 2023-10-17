using powerplant_coding_challenge.Models;

namespace powerplant_coding_challenge.Interfaces
{
    public interface IPowerPlantCalculatorFactory
    {
        IPowerPlantCalculator GetCalculator(PowerPlantType type);
    }
}
