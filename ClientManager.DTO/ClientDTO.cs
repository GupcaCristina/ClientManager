using System;
using System.Collections.Generic;
using System.Text;

namespace ClientManager.DTO
{
    public class ClientDTO
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime AddedDate { get; set; }
        public int NumberOfEventsBooked { get; set; }
        public ContactDetailsDTO Contacts { get; set; }

    }
}
