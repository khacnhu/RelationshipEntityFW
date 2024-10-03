namespace RelationshipEntityFW.Models
{
    public class StudentSubject
    {

        public Student? Student { get; set; }
        public int StudentId { get; set; }


        public Subject? Subject { get; set; }
        public int SubjectId { get; set; }  

    }
}
