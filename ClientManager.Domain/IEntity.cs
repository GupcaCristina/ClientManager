using System;
using System.Collections.Generic;
using System.Text;

namespace ClientManager.Domain
{
    interface IEntity<TId>
    {
        TId Id { get; set; }
    }   
}
