using DomainUtil;
using System;
using System.Collections.Generic;
using System.Text;
using ClientManager.DTO;

namespace ClientManager.BLL.Interfaces
{
    public interface IEventServices
    {
        EventDTO GetClientDetails(long id);
        PaginatedList<EventDTO> GetPaginatedList(int pageSize, DateTime? addedDate,  int page);
       // void AddClient(CreateClientDTO client);
        void EditClient(EventDTO client);
    }
}
