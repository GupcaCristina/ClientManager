using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClientManager.Domain
{
    public class Event:Entity<long>
    {
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public EventType EventType { get; set; }
        public Client Client { get; set; }
        public Address Address { get; set; }
    }
}
