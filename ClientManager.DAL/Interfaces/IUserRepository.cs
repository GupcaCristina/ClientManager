using ClientManager.Domain;

namespace LearningPortal.DAL.Interfaces
{
    public interface IUserRepository
    {
        ApplicationUser GetUserById(string id);
    }
}
