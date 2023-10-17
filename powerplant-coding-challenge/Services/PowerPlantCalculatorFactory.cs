using powerplant_coding_challenge.Interfaces;
using powerplant_coding_challenge.Models;

namespace powerplant_coding_challenge.Services
{
    public class PowerPlantCalculatorFactory : IPowerPlantCalculatorFactory
    {
        public IPowerPlantCalculator GetCalculator(PowerPlantType type)
        {
            switch (type)
            {
                case PowerPlantType.Gasfired:
                    return new GasFiredCalculator();
                case PowerPlantType.Turbojet:
                    return new TurboJetCalculator();
                case PowerPlantType.Windturbine:
                    return new WindTurbineCalculator();
                default:
                    throw new NotSupportedException("Unsupported PowerPlantType");
            }
        }
    }
}
