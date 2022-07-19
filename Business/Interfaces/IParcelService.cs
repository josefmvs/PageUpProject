using PageUpProject.Models;
using PageUpProject.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageUpProject.Business.Interfaces
{
    public interface IParcelService
    {
        AddParcelResponse ComputeCost(Parcel parcel);
    }
}
