using System;
using System.Collections.Generic;
using System.Text;

namespace ClientManager.Domain
{
    public class EventType:Entity<long>
    {
        public string Type { get; set; }
        public List<Event> Events { get; set; }= new List<Event>();

    }
}
