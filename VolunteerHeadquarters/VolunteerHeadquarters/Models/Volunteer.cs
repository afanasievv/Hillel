namespace VolunteerHeadquarters.Models
{
    public class Volunteer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Biography { get; set; }
        public ICollection<Organization> Organizations { get; set; }
    }

}
