using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientManager.Domain;

namespace ClientManager.DAL.Interfaces
{
    public interface IClientRepository
    {
        IQueryable<Client> GetClientList();
        Client GetClientById(long id);
        Client GetClientDetails(long id);

    }
}
