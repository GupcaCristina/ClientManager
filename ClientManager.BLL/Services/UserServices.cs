using AutoMapper;
using ClientManager.BLL.Interfaces;
using LearningPortal.DAL.Interfaces;

namespace ClientManager.BLL.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserServices(IUserRepository userRepository,
                            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        //public UserDetailsDTO GetUserDetails(string id)
        //{
        //    var user = _userRepository.GetUserById(id);
        //    var userDetails = _mapper.Map<UserDetailsDTO>(user);

        //    return userDetails;
        //}

    }
}
