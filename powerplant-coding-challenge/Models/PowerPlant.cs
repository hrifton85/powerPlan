using System.Text.Json.Serialization;

namespace powerplant_coding_challenge.Models
{
    public class PowerPlant
    {
        public string Name { get; set; }
        [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
        public PowerPlantType Type { get; set; }
        public decimal Efficiency { get; set; }
        public decimal Pmin { get; set; }
        public decimal Pmax { get; set; }   
    }

}
