
using Microsoft.EntityFrameworkCore;

using System.Linq;

using ClientManager.DAL.Interfaces;
using ClientManager.Domain;
using ClientManager.DAL.Repositories;



namespace ClientManager.DAL.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(DbContext context):base(context)
        {
            
        }

        public Client GetClientById(long id)
        {
            var client = _dbset.Find(id);
            return client;
        }

        public IQueryable<Client> GetClientList()
        {
            var clients = Get();
            return clients;
        }

        public Client GetClientDetails(long id)
        {
            var client = Get().Where(p=>p.Id==id).Include(s=>s.Contacts).FirstOrDefault();
            return client;
        }
    }
}
