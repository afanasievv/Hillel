namespace DataLibrary.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Description { get; set; }

        public ICollection<Volunteer> Volunteers { get; set; }
        public ICollection<Request> CompletedRequests { get; set; }

        public ICollection<Request> TakenRequests { get; set; }
    }
}
