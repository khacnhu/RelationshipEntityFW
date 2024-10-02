using RelationshipEntityFW.Models;

namespace RelationshipEntityFW.DTOs
{
    public class CarCompanyDTO
    {
        public string? Name { get; set; }


        // Relationship: one to one
        public int? CarModelId { get; set; }
        public string ModelName { get; set; }

    }
}
