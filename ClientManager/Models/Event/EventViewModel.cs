using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientManager.Web.Models.ClientViewModels;

namespace ClientManager.Web.Models.Event
{
    public class EventViewModel
    {
        public long Id { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public string EventType { get; set; }
        public ClientDetailsViewModel Client { get; set; }
        public AddressViewModel Address { get; set; }
    }

}
