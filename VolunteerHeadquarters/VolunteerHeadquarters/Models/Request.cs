namespace VolunteerHeadquarters.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Importance { get; set; }
        public Volunteer Volunteer { get; set; }
        public Organization Organization { get; set; }
        public MilitaryUnit MilitaryUnit { get; set; }
    }
}
