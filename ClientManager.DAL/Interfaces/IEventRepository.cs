using System.Linq;
using ClientManager.Domain;

namespace ClientManager.DAL.Interfaces
{
    public interface IEventRepository
    {
        IQueryable<Event> GetEventsByClient(long id);
    }
}
