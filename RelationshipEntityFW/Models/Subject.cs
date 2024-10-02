using System.Text.Json.Serialization;

namespace RelationshipEntityFW.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }


        // Relationship
        [JsonIgnore]
        public List<Student>? Students { get; set; }
    }
}
