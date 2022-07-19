using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PageUpProject.Models;

namespace PageUpProject.Business.Interfaces
{
    public interface IRule<TEntity>
    {

        //int Order();
        double Cost(TEntity parcel, double costFactor);

        bool Condition(TEntity parcel);
    }
}
