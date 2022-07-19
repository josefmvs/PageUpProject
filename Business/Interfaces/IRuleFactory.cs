
using PageUpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageUpProject.Business.Interfaces
{
    public interface IRuleFactory
    {
        IRule<Parcel> CreateRule();

        bool IsConditionMet(Parcel item);

        //add static method to handle priority order
        //get rules and their priority set and database
        //loop length of all rules then loop from top to bottom according to index
       
    }
}
