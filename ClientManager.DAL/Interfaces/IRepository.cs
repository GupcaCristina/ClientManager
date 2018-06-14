using System.Collections.Generic;
using System.Linq;

namespace ClientManager.DAL.Interfaces
{   
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get();
        TEntity GetById(long id);
        void Add(TEntity entity);
        void AddRange(IList<TEntity> values);
        void Delete(long id);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void SaveChanges();
    }
}
