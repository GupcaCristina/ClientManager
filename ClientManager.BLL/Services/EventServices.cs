using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using ClientManager.BLL.Interfaces;
using ClientManager.DAL.Interfaces;
using ClientManager.Domain;
using ClientManager.DTO;
using DomainUtil;

namespace ClientManager.BLL.Services
{
    public class EventServices:IEventServices
    {
        private IRepository<Event> _repository;
        private IEventRepository _eventRepository;

        private IMapper _mapper;


        public EventServices(IMapper mapper,
                            IRepository<Event> repository,
                            IEventRepository eventRepository)
        {
            _repository = repository;
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public void EditEvent(EventDTO client)
        {
            throw new NotImplementedException();
        }

        public EventDTO GetEventDetails(long id)
        {
            throw new NotImplementedException();
        }

        public List<EventDTO> GetEventsByClient(long id)
        {
            var events = _eventRepository.GetEventsByClient(id).ToList();
            var eventsDto = _mapper.Map<List<EventDTO>>(events);
            for (int i = 0; i < eventsDto.Count(); i++)
            {
                eventsDto[i].EventType = events[i].EventType.Type;

            }
            return eventsDto;
        }

        public PaginatedList<EventDTO> GetPaginatedList(int pageSize, DateTime? date,int page = 0)
        {
            var allEvents = date.HasValue ? _eventRepository.GetEventList()
                .Where(p => p.Date == date) : _eventRepository.GetEventList();

            var orderedEvents = allEvents.OrderByDescending(p => p.Date);

            var events = PaginatedList<Event>.Create(orderedEvents, page > 0 ? page : 1, pageSize);
            var eventsDto = _mapper.Map<List<EventDTO>>(events);
            for (int i = 0; i < eventsDto.Count(); i++)
            {
                eventsDto[i].EventType = events[i].EventType.Type;

            }
            var paginatedListOfClients = new PaginatedList<EventDTO>(eventsDto, eventsDto.Count, page, pageSize);

           

            return paginatedListOfClients;
        }
    }
}
