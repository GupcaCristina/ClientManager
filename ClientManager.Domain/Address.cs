using System.ComponentModel.DataAnnotations.Schema;

namespace ClientManager.Domain
{
    public class Address:Entity<long>
    {       
        public string Country { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public Event Event { get; set; }
        [ForeignKey("Event")]
        public long EventId { get; set; }
    }
}
