using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ClientManager.Domain;
using ClientManager.DTO;

namespace ClientManager.BLL.Profiles
{
    public class ClientProfile:Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientDTO>()
                .ForMember(dest => dest.NumberOfEventsBooked, opt => opt.Ignore())
                .ForPath(dest => dest.Contacts,
                    src => src.MapFrom(model => model.Contacts));
        }
    }
}
