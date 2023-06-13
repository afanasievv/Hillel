namespace VolunteerHeadquarters.Models
{
    public class MilitaryUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public string ContactPerson { get; set; }

        
        public ICollection<Request> ActiveRequests { get; set; }

       
        public ICollection<Request> CompletedRequests { get; set; }

    }
}
