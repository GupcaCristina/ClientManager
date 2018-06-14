using System;
using System.Collections.Generic;
using System.Text;

namespace ClientManager.DTO
{
    public class CreateClientDTO
    {
        public long Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
    }
}
