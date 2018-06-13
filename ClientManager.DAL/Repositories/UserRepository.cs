using ClientManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClientManager.DAL.Repositories

{
    public class UserRepository : Repository<ApplicationUser>
    {
      
    
    public UserRepository(DbContext context) : base(context)
    {

    }
        public ApplicationUser GetUserById(string id)
        {
           var user= _dbset.Find(id);

            return user;
        }

    }
}
