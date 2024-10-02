namespace RelationshipEntityFW.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string? Model { get; set; }


        // Relationship : one to one
        public CarCompany? CarCompany { get; set; } // Navigate property
        public int CarCompanyId { get; set; } // ForeignKey

    }
}
