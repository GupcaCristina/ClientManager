using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientManager.Web.Models.Contacts;

namespace ClientManager.Web.Models.ClientViewModels
{
    public class ClientDetailsViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime AddedDate { get; set; }
        public int NumberOfEventsBooked { get; set; }
        public ContactDetailsViewModel Contacts { get; set; }

    }
}
