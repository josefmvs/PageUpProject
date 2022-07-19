using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageUpProject.Business.Interfaces
{
    public interface IRangeDataRepository<TEntity>
    {
        void AddRange(TEntity[] entities);
        void ChangeRange(TEntity[] entities);

    }
}
