using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientManager.DAL.Interfaces;
using ClientManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClientManager.DAL.Repositories
{
    public class EventRepository:Repository<Event>,IEventRepository
    {
        public EventRepository(DbContext context) : base(context)
        {

        }

        public IQueryable<Event> GetEventList()
        {
            return Get()
                .Include(m => m.EventType)
                .Include(m => m.Address)
                .Include(m=>m.Client);
        }

        public IQueryable<Event> GetEventsByClient(long id)
        {
            var events = Get().Where(p => p.Client.Id == id);
            return events;
        }
    }
}
