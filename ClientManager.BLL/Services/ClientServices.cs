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
using LearningPortal.DAL.Interfaces;

namespace ClientManager.BLL.Services
{
    public class ClientServices:IClientServices
    {
        private IClientRepository _clientRepository;
        private IRepository<Client> _repository;
        private IEventRepository _eventRepository;
        private IMapper _mapper;
        public ClientServices(  IClientRepository clientRepository, 
                                IMapper mapper,
                                IEventRepository eventRepository,
                                IRepository<Client> repository
                            )
        {
            _clientRepository = clientRepository;
            _eventRepository = eventRepository;
            _mapper = mapper;
            _repository = repository;
        }

        public void AddClient(CreateClientDTO clientDto)
        {
            var client = new Client()
            {
                BirthDate = clientDto.BirthDate,
                AddedDate = DateTime.Now,
                FirstName = clientDto.FirstName,
                LastName = clientDto.LastName,
                Contacts = new Contacts()
                {
                    Email = clientDto.Email,
                    Phone1 = clientDto.Phone1,
                    Phone2 = clientDto.Phone2,
                    Facebook = clientDto.Facebook,
                    Instagram = clientDto.Instagram,
                    Website = clientDto.Website
                }
            };
           _repository.Add(client);
           _repository.SaveChanges();
        }

        public void EditClient(ClientDTO clientDto)
        {
            var client = new Client()
            {
                Id = clientDto.Id,
                BirthDate = clientDto.BirthDate,
                AddedDate = DateTime.Now,
                FirstName = clientDto.FirstName,
                LastName = clientDto.LastName,
                

            };
            _repository.Update(client);
            _repository.SaveChanges();
        }

        public ClientDTO GetClientDetails(long id)
        {
            var client = _clientRepository.GetClientDetails(id);
            var clientDto = _mapper.Map<ClientDTO>(client);

            var numberOfEventsBooked = _eventRepository.GetEventsByClient(id).ToList() ?? new List<Event>(); 

            clientDto.NumberOfEventsBooked = numberOfEventsBooked.Count()==0 ? 0 : numberOfEventsBooked.Count();


            return clientDto;

        }

        public List<ClientDTO> GetClientsByBirthday()
        {
            var clients = _repository.Get().Where(p => p.BirthDate.Date == DateTime.Now.Date).ToList();
            var clientsDto = _mapper.Map<List<ClientDTO>>(clients);
            return clientsDto;

        }

        public PaginatedList<ClientDTO> GetPaginatedList(int pageSize, DateTime? addedDate, string searchString, int page = 0)
        {
            var allClients = addedDate.HasValue ? _clientRepository.GetClientList()
                .Where(p => p.AddedDate == addedDate) : _clientRepository.GetClientList();
            if (!String.IsNullOrEmpty(searchString))
            {
                allClients = allClients.Where(s => s.FirstName.ToLower().Contains(searchString.ToLower()) || s.LastName.ToLower().Contains(searchString.ToLower()));
            }
            var orderedClients = allClients.OrderByDescending(p => p.AddedDate);

            var clients = PaginatedList<Client>.Create(orderedClients, page > 0 ? page : 1, pageSize);
            var clientsDTO = _mapper.Map<List<ClientDTO>>(clients);
            var paginatedListOfClients = new PaginatedList<ClientDTO>(clientsDTO, clientsDTO.Count, page, pageSize);
            foreach (var item in paginatedListOfClients)
            {
                var numberOfEventsBooked = _eventRepository.GetEventsByClient(item.Id).ToList() ?? new List<Event>();

                item.NumberOfEventsBooked = numberOfEventsBooked.Count() == 0 ? 0 : numberOfEventsBooked.Count();
            }

            return paginatedListOfClients;
        }
    }
}
