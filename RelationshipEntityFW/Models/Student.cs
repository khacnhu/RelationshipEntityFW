using System.Text.Json.Serialization;

namespace RelationshipEntityFW.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        // Relationship
        //[JsonIgnore]
        //public List<Subject>? Subjects { get; set; }
        public ICollection<StudentSubject>? StudentSubjects { get; set; }
    }
}
