using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClientManager.Domain
{
    public class Client:Entity<long>
    {
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime AddedDate { get; set; }

        public List<Event> Events { get; set; } = new List<Event>();
        public Contacts Contacts { get; set; }

    }
}
