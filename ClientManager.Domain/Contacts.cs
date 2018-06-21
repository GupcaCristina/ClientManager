using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClientManager.Domain
{
    public class Contacts:Entity<long>
    {
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }

        [ForeignKey("Client")]
        public long ClientId { get; set; }
        public Client Client { get; set; }
    }
}
