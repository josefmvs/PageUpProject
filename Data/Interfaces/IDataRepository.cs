using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageUpProject.Business.Interfaces
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        //TEntity Get(string id);
        //void Add(TEntity entity);
        //void Change(TEntity dbEntity, TEntity entity);
        //void Delete(TEntity entity);
    }
}
