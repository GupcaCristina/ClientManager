using ClientManager.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using DomainUtil;

namespace ClientManager.BLL.Interfaces
{
    public interface IClientServices
    {
        ClientDTO GetClientDetails(long id);
        PaginatedList<ClientDTO> GetPaginatedList(int pageSize, DateTime? addedDate,string searchString, int page);
        void AddClient(CreateClientDTO client);
        void EditClient(ClientDTO client);

    }
}
