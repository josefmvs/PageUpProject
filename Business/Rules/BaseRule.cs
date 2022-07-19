using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageUpProject.Models
{
    public abstract class BaseRule
    {
        //public abstract double CostFactor { get; set; }
        public abstract int WeightFactor { get; set; }
    }
}
