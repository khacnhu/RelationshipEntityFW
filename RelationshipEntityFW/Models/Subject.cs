using System.Text.Json.Serialization;

namespace RelationshipEntityFW.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }


        // Relationship
        //public List<Student>? Students { get; set; }
        //[JsonIgnore]
        public ICollection<StudentSubject>? StudentSubjects { get; set; }

    }
}
