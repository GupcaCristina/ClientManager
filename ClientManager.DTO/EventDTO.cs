using System;
using System.Collections.Generic;
using System.Text;

namespace ClientManager.DTO
{
    public class EventDTO
    {
        public long Id { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public string EventType { get; set; }
        public ClientDTO Client { get; set; }
        public AddressDTO Address { get; set; }
    }
}
