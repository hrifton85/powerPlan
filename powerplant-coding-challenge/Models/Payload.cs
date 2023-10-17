using System.Text.Json.Serialization;
namespace powerplant_coding_challenge.Models
{
 

    public class Payload
    {
        public decimal Load { get; set; }
        [JsonPropertyName("fuels")]
        public Fuel Fuels { get; set; }
        public IEnumerable<PowerPlant> PowerPlants { get; set; }       
    }
}
