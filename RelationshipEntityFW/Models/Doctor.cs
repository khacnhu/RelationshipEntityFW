using System.Text.Json.Serialization;

namespace RelationshipEntityFW.Models
{
    public class Doctor
    {

        public int Id { get; set; } 
        public string? Name { get; set; }

        [JsonIgnore]
        public List<Patient> Patients { get; set; } = new List<Patient>();

    }
}
